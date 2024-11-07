using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Kartverket_group2.Data;

namespace Kartverket_group2.Controllers
{

    public class UserSubmissionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<UserSubmissionsController> _logger;

        public UserSubmissionsController(
            ApplicationDbContext context,
            ILogger<UserSubmissionsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: UserSubmissions
        [Authorize(Roles = "User")]
        public async Task<IActionResult> MySubmissions(int page = 1, int pageSize = 10)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var submissions = await _context.Submissions
                .Where(s => s.UserId == userId)
                .OrderByDescending(s => s.Timestamp)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return View(submissions);
        }

        // POST: UserSubmissions/Delete/5
        [Authorize(Roles = "User")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var submission = await _context.Submissions
                .FirstOrDefaultAsync(s => s.Id == id && s.UserId == userId);

            if (submission == null)
            {
                // Return NotFound if the submission doesn't exist or doesn't belong to the user
                return NotFound();
            }

            try
            {
                _context.Submissions.Remove(submission);
                await _context.SaveChangesAsync();

                _logger.LogInformation("User {UserId} successfully deleted submission {SubmissionId}",
                    userId, id);

                TempData["Message"] = "Submission successfully deleted.";
                return RedirectToAction(nameof(MySubmissions));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while user {UserId} attempted to delete submission {SubmissionId}",
                    userId, id);

                TempData["Error"] = "An error occurred while deleting the submission. Please try again.";
                return RedirectToAction(nameof(MySubmissions));
            }
        }
    }
}
