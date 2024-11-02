using Microsoft.AspNetCore.Mvc;

namespace Kartverket_group2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
