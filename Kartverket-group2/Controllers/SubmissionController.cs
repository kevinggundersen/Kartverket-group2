using Microsoft.AspNetCore.Mvc;

namespace Kartverket_group2.Controllers
{
    public class SubmissionController : Controller
    {
        public IActionResult Submission()
        {
            return View();
        }
    }
}
