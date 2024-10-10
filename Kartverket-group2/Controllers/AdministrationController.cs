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


        public async Task<IActionResult> Admin()
        {
            var submissions = await _context.Submissions.ToListAsync();
            return View(submissions);
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
                if (firstFeature != null && firstFeature.Geometry.Type == "Point")
                {
                    var coordinates = (JsonElement)firstFeature.Geometry.Coordinates;
                    var longitude = coordinates[0].GetDouble();
                    var latitude = coordinates[1].GetDouble();

                    try
                    {
                        submission.Municipality = await _kartverketApiService.GetMunicipalityAsync(longitude, latitude);
                    }
                    catch (HttpRequestException ex)
                    {
                        _logger.LogError(ex, "Error fetching municipality data from Kartverket API");
                        submission.Municipality = "Unable to determine";
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
    }
}