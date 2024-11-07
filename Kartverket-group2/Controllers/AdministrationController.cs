using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kartverket_group2.Data;
using Kartverket_group2.Models;
using System.Threading.Tasks;
using Kartverket_group2.Services;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Kartverket_group2.Controllers
{

    public class AdministrationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly KartverketApiService _kartverketApiService;
        private readonly IEmailService _emailService;
        private readonly ILogger<AdministrationController> _logger;
        private readonly UserManager<ApplicationUserModel> _userManager;

        public AdministrationController(
            ApplicationDbContext context, 
            KartverketApiService kartverketApiService, 
            ILogger<AdministrationController> logger,
            IEmailService emailService,
            UserManager<ApplicationUserModel> userManager)
        {
            _context = context;
            _kartverketApiService = kartverketApiService;
            _logger = logger;
            _emailService = emailService;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Admin(
            string[] statusFilter,
            int? municipalityMin,
            int? municipalityMax,
            int? municipalitySingle,
            string municipalitySearchType = "single", // Set default value
            int page = 1,
            int pageSize = 25,
            string sortColumn = "Timestamp",
            bool sortDescending = true)
        {
            var query = _context.Submissions.AsQueryable();

            // Apply status filter if any statuses are selected
            if (statusFilter != null && statusFilter.Length > 0)
            {
                query = query.Where(s => statusFilter.Contains(s.Status));
            }

            // Apply municipality filter based on search type
            if (!string.IsNullOrEmpty(municipalitySearchType))
            {
                if (municipalitySearchType == "single" && municipalitySingle.HasValue)
                {
                    string singleValue = municipalitySingle.Value.ToString().PadRight(4, '0');
                    query = query.Where(s => s.Municipalitynr == singleValue);
                }
                else if (municipalitySearchType == "range")
                {
                    if (municipalityMin.HasValue)
                    {
                        string minValue = municipalityMin.Value.ToString().PadRight(4, '0');
                        query = query.Where(s => string.Compare(s.Municipalitynr, minValue) >= 0);
                    }

                    if (municipalityMax.HasValue)
                    {
                        string maxValue = municipalityMax.Value.ToString().PadRight(4, '9');
                        query = query.Where(s => string.Compare(s.Municipalitynr, maxValue) <= 0);
                    }
                }
            }

            // Apply sorting
            query = sortColumn?.ToLower() switch
            {
                "id" => sortDescending ? query.OrderByDescending(s => s.Id) : query.OrderBy(s => s.Id),
                "userid" => sortDescending ? query.OrderByDescending(s => s.UserId) : query.OrderBy(s => s.UserId),
                "comment" => sortDescending ? query.OrderByDescending(s => s.Comment) : query.OrderBy(s => s.Comment),
                "timestamp" => sortDescending ? query.OrderByDescending(s => s.Timestamp) : query.OrderBy(s => s.Timestamp),
                "status" => sortDescending ? query.OrderByDescending(s => s.Status) : query.OrderBy(s => s.Status),
                "municipalitynr" => sortDescending ? query.OrderByDescending(s => s.Municipalitynr) : query.OrderBy(s => s.Municipalitynr),
                _ => query.OrderBy(s => s.Id)
            };

            int totalItems = await query.CountAsync();

            var submissions = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var viewModel = new AdminViewModel
            {
                Submissions = submissions,
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems,
                CurrentSortColumn = sortColumn,
                SortDescending = sortDescending,
                StatusFilter = statusFilter,
                MunicipalityMin = municipalityMin,
                MunicipalityMax = municipalityMax,
                MunicipalitySingle = municipalitySingle,
                MunicipalitySearchType = municipalitySearchType
            };

            return View(viewModel);
        }

        [Authorize(Roles = "User")]
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

                submission.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                _context.Submissions.Add(submission);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Map");
            }
            catch (JsonException ex)
            {
                _logger.LogError(ex, "Error deserializing submission data");
                return RedirectToAction("Index", new { message = "Error processing shape data." });
            }
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ViewSubmissionDetails(long id)
        {
            var submission = await _context.Submissions.FindAsync(id);
            if (submission == null)
            {
                return NotFound();
            }
            return View(submission);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateStatus(long id, string status, bool skipEmail)
        {
            var submission = await _context.Submissions.FindAsync(id);
            if (submission == null)
            {
                return NotFound();
            }

            var oldStatus = submission.Status;
            submission.Status = status;
            await _context.SaveChangesAsync();

            if (!skipEmail && oldStatus != status)
            {
                var user = await _userManager.FindByIdAsync(submission.UserId);
                if (user != null)
                {
                    try
                    {
                        await _emailService.QueueEmailAsync(new EmailQueueMessage
                        {
                            UserEmail = user.Email,
                            SubmissionId = submission.Id.ToString(),
                            NewStatus = status
                        });

                        _logger.LogInformation("Email queued for sending to {UserEmail}", user.Email);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Failed to queue email for submission {SubmissionId}", id);
                    }
                }
            }

            return RedirectToAction("ViewSubmissionDetails", new { id = id });
        }



        [Authorize(Roles = "Admin")]
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