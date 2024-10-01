using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Collections.Generic;
using Kartverket_group2.Models;  

namespace Kartverket_group2.Controllers
{
    public class MapController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveShapes(string shapeData)
        {

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            
            List<Shape> shapes = JsonSerializer.Deserialize<List<Shape>>(shapeData, options);

            // Store the shape data in TempData for now (or in a database in the future)
            TempData["ShapeData"] = shapeData;

            return RedirectToAction("ViewShapes");
        }

        [HttpGet]
        public ActionResult ViewShapes()
        {
            // Get the shape data from TempData
            var shapeData = TempData["ShapeData"] as string;
     

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<Shape> shapes = JsonSerializer.Deserialize<List<Shape>>(shapeData, options);

            // Pass the shapes list to the view
            return View(shapes);
        }
    }
}