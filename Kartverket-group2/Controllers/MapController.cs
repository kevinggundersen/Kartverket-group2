using Microsoft.AspNetCore.Mvc;

namespace Kartverket_group2.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
