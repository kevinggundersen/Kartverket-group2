using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Kartverket_group2.Models;
using System.Collections.Generic;

namespace Kartverket_group2.Controllers
{
    public class AdministrationController : Controller
    {
        private static List<Submission> submissions = new List<Submission>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveShapes(string shapeData)
        {
            if (string.IsNullOrEmpty(shapeData))
            {
                return RedirectToAction("Index", new { message = "No shape data received." });
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            try
            {
                Submission? submission = JsonSerializer.Deserialize<Submission>(shapeData, options);
                if (submission != null)
                {
                    submissions.Add(submission);
                }

                return RedirectToAction("Admin");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing submission data: {ex.Message}");
                return RedirectToAction("Index", new { message = "Error processing shape data." });
            }
        }

        public IActionResult Admin()
        {
            return View(submissions);
        }

        public IActionResult ViewSubmissionDetails(long id)
        {
            var submission = submissions.Find(s => s.Id == id);
            if (submission == null)
            {
                return NotFound();
            }
            return View(submission);
        }

        [HttpPost]
        public IActionResult UpdateStatus(long id, string status)
        {
            var submission = submissions.Find(s => s.Id == id);
            if (submission == null)
            {
                return NotFound();
            }

            submission.Status = status;
            return RedirectToAction("ViewSubmissionDetails", new { id = id });
        }
    }
}