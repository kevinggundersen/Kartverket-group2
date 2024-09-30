using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;  // Add this line
using System.Collections.Generic;
using Kartverket_group2.Models;  // Your model namespace

namespace Kartverket_group2.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveShapes(string shapeData)
        {
            // Deserialize the JSON data to a list of Shape objects
            List<Shape> shapes = JsonConvert.DeserializeObject<List<Shape>>(shapeData);

            // Store the shape data in TempData for now (or in a database in the future)
            TempData["ShapeData"] = shapeData;

            return RedirectToAction("ViewShapes");
        }

        public ActionResult ViewShapes()
        {
            // Get the shape data from TempData
            var shapeData = TempData["ShapeData"] as string;
            List<Shape> shapes = JsonConvert.DeserializeObject<List<Shape>>(shapeData);

            // Pass the shapes list to the view
            return View(shapes);
        }
    }
}
