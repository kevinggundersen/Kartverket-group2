using Kartverket_group2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kartverket_group2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Hjelp()
<<<<<<< HEAD
        {
            return View();
        }
        public IActionResult Profile()
=======
>>>>>>> 47be2a48966766e6b01a943233856117a7bb0a18
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
