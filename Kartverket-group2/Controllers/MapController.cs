using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Kartverket_group2.Models;
using Microsoft.AspNetCore.Authorization;

namespace Kartverket_group2.Controllers
{
    /// <summary>
    /// Controller responsible for handling map-related functionality and shape data management.
    /// </summary>
    public class MapController : Controller
    {
        /// <summary>
        /// Displays the main map interface. Requires authenticated user.
        /// Redirects to welcome page if user is not authenticated.
        /// </summary>
        [Authorize]
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Welcome", "Home");
            }

            return View();
        }

        /// <summary>
        /// Displays confirmation page after successful shape submission.
        /// </summary>
        public IActionResult Confirmation()
        {
            return View();
        }

        /// <summary>
        /// Handles saving of shape data submitted from the map interface.
        /// Deserializes GeoJSON data and temporarily stores it.
        /// </summary>
        /// <param name="shapeData">GeoJSON string containing shape information</param>
        [Authorize]
        [HttpPost]
        public ActionResult SaveShapes(string shapeData)
        {
            if (string.IsNullOrEmpty(shapeData))
            {
                return RedirectToAction("Index", new { message = "No shape data received." });
            }

            // Configure JSON deserialization options for case-insensitive property matching
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            try
            {
                // Attempt to deserialize the GeoJSON data
                GeoJsonFeatureCollection? geoJsonData = JsonSerializer.Deserialize<GeoJsonFeatureCollection>(shapeData, options);

                // Store data temporarily for the next request
                TempData["GeoJsonData"] = shapeData;

                return RedirectToAction("ViewShapes");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing GeoJSON data: {ex.Message}");
                return RedirectToAction("Index", new { message = "Error processing shape data." });
            }
        }

        /// <summary>
        /// Displays the shapes previously saved in TempData.
        /// Returns empty collection if no data is found.
        /// </summary>
        [Authorize]
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

            // Deserialize and display the saved GeoJSON data
            GeoJsonFeatureCollection? featureCollection = JsonSerializer.Deserialize<GeoJsonFeatureCollection>(geoJsonData, options);
            return View(featureCollection);
        }
    }
}