using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kartverket_group2.Data;
using Kartverket_group2.Models;
using System.Threading.Tasks;
using Kartverket_group2.Services;
using System.Text.Json;

namespace Kartverket_group2.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly KartverketApiService _kartverketApiService;
        private readonly ILogger<AdministrationController> _logger;

        public AdministrationController(ApplicationDbContext context, KartverketApiService kartverketApiService, ILogger<AdministrationController> logger)
        {
            _context = context;
            _kartverketApiService = kartverketApiService;
            _logger = logger;
        }


        public async Task<IActionResult> Admin(string statusFilter, string municipalityFilter, int page = 1, int pageSize = 10)
        {
            var query = _context.Submissions.AsQueryable();

            // Multi-status filter
            if (!string.IsNullOrEmpty(statusFilter))
            {
                var statuses = statusFilter.Split(','); // Split the comma-separated statuses
                query = query.Where(s => statuses.Contains(s.Status));
            }

            if (!string.IsNullOrEmpty(municipalityFilter))
            {
                query = query.Where(s => s.Municipalitynr == municipalityFilter);
            }

            // Total count for pagination
            int totalItems = await query.CountAsync();

            // Apply pagination
            var submissions = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var viewModel = new AdminViewModel
            {
                Submissions = submissions,
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SaveShapes(string shapeData)
        {
            if (string.IsNullOrEmpty(shapeData))
            {
                return RedirectToAction("Index", new { message = "No shape data received." });
            }

            try
            {
                var submission = JsonSerializer.Deserialize<Submission>(shapeData);

                var firstFeature = submission.GeoJsonData.Features.FirstOrDefault();
                
                if (firstFeature != null)
                {
                    try
                    {
                        var (longitude, latitude) = GeoJsonCoordinateExtractor.ExtractFirstCoordinates(firstFeature.Geometry);
                        submission.Municipalitynr = await _kartverketApiService.GetMunicipalityNumberAsync(longitude, latitude);
                    }
                    catch (HttpRequestException ex)
                    {
                        _logger.LogError(ex, "Error fetching municipality data from Kartverket API");
                        submission.Municipalitynr = "Unable to determine";
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error extracting coordinates from geometry");
                        submission.Municipalitynr = "Unable to determine";
                    }
                }

                _context.Submissions.Add(submission);
                await _context.SaveChangesAsync();

                return RedirectToAction("Admin");
            }
            catch (JsonException ex)
            {
                _logger.LogError(ex, "Error deserializing submission data");
                return RedirectToAction("Index", new { message = "Error processing shape data." });
            }
        }

        public async Task<IActionResult> ViewSubmissionDetails(long id)
        {
            var submission = await _context.Submissions.FindAsync(id);
            if (submission == null)
            {
                return NotFound();
            }
            return View(submission);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStatus(long id, string status)
        {
            var submission = await _context.Submissions.FindAsync(id);
            if (submission == null)
            {
                return NotFound();
            }

            submission.Status = status;
            await _context.SaveChangesAsync();
            return RedirectToAction("ViewSubmissionDetails", new { id = id });
        }

        [HttpPost]
        public IActionResult DeleteSubmission(long id)
        {
            var submission = _context.Submissions.Find(id);
            if (submission != null)
            {
                _context.Submissions.Remove(submission);
                _context.SaveChanges();
            }
            return RedirectToAction("Admin");
        }


        public class GeoJsonCoordinateExtractor
        {
            public static (double longitude, double latitude) ExtractFirstCoordinates(GeoJsonGeometry geometry)
            {
                return geometry.Type switch
                {
                    "Point" => ExtractPointCoordinates(geometry.Coordinates),
                    "LineString" => ExtractLineStringCoordinates(geometry.Coordinates),
                    "Polygon" => ExtractPolygonCoordinates(geometry.Coordinates),
                    "MultiPolygon" => ExtractMultiPolygonCoordinates(geometry.Coordinates),
                    "MultiLineString" => ExtractMultiLineStringCoordinates(geometry.Coordinates),
                    "MultiPoint" => ExtractMultiPointCoordinates(geometry.Coordinates),
                    _ => throw new ArgumentException($"Unsupported geometry type: {geometry.Type}")
                };
            }

            private static (double longitude, double latitude) ExtractPointCoordinates(object coordinates)
            {
                var coords = ((JsonElement)coordinates).EnumerateArray().ToArray();
                return (coords[0].GetDouble(), coords[1].GetDouble());
            }

            private static (double longitude, double latitude) ExtractLineStringCoordinates(object coordinates)
            {
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                return ExtractPointCoordinates(coordArray.First());
            }

            private static (double longitude, double latitude) ExtractPolygonCoordinates(object coordinates)
            {
                // Get the first ring (exterior ring)
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                var firstRing = coordArray.First();
                // Get the first point of the ring
                var firstPoint = firstRing.EnumerateArray().First();
                return ExtractPointCoordinates(firstPoint);
            }

            private static (double longitude, double latitude) ExtractMultiPolygonCoordinates(object coordinates)
            {
                // Get the first polygon
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                return ExtractPolygonCoordinates(coordArray.First());
            }

            private static (double longitude, double latitude) ExtractMultiLineStringCoordinates(object coordinates)
            {
                // Get the first linestring
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                return ExtractLineStringCoordinates(coordArray.First());
            }

            private static (double longitude, double latitude) ExtractMultiPointCoordinates(object coordinates)
            {
                // Get the first point
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                return ExtractPointCoordinates(coordArray.First());
            }
        }
    }
}