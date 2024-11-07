using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Kartverket_group2.Models;
using Microsoft.AspNetCore.Authorization;

namespace Kartverket_group2.Controllers
{
    public class MapController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Welcome", "Home");
            }

            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveShapes(string shapeData)
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
                GeoJsonFeatureCollection? geoJsonData = JsonSerializer.Deserialize<GeoJsonFeatureCollection>(shapeData, options);

                // Store the GeoJSON data in TempData for now (or in a database in the future)
                TempData["GeoJsonData"] = shapeData;

                return RedirectToAction("ViewShapes");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing GeoJSON data: {ex.Message}");
                return RedirectToAction("Index", new { message = "Error processing shape data." });
            }
        }

        public ActionResult ViewShapes()
        {
            var geoJsonData = TempData["GeoJsonData"] as string;
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            if (string.IsNullOrEmpty(geoJsonData))
            {
                return View("ViewShapes", new GeoJsonFeatureCollection());
            }

            GeoJsonFeatureCollection? featureCollection = JsonSerializer.Deserialize<GeoJsonFeatureCollection>(geoJsonData, options);

            return View(featureCollection);
        }
    }
}