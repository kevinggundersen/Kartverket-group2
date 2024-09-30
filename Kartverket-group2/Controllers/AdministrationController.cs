using Microsoft.AspNetCore.Mvc;

namespace Kartverket_group2.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}
