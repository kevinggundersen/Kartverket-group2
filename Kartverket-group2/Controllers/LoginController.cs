using Kartverket_group2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kartverket_group2.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<ApplicationUserModel> _signInManager;
        private readonly UserManager<ApplicationUserModel> _userManager;
        private readonly ILogger<LoginController> _logger;

        public LoginController(
            SignInManager<ApplicationUserModel> signInManager,
            UserManager<ApplicationUserModel> userManager,
            ILogger<LoginController> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Log the attempt
                _logger.LogInformation($"Login attempt for user: {model.EmailOrUsername}");

                var user = await _userManager.FindByEmailAsync(model.EmailOrUsername)
                    ?? await _userManager.FindByNameAsync(model.EmailOrUsername);

                if (user != null)
                {
                    _logger.LogInformation($"User found with ID: {user.Id}");

                    // Check if user is in Admin role before sign in
                    var isInAdminRole = await _userManager.IsInRoleAsync(user, "Admin");
                    _logger.LogInformation($"User is in Admin role: {isInAdminRole}");

                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    _logger.LogInformation($"Sign in result: {result.Succeeded}");
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User logged in successfully");

                        // After successful login, verify the authentication
                        var isAuthenticated = User.Identity?.IsAuthenticated ?? false;
                        _logger.LogInformation($"User.Identity.IsAuthenticated: {isAuthenticated}");

                        if (isInAdminRole)
                        {
                            _logger.LogInformation("Redirecting to Admin page");
                            return RedirectToAction("Admin", "Administration");
                        }

                        _logger.LogInformation("Redirecting to Map page");
                        return RedirectToAction("Index", "Map");
                    }
                    else
                    {
                        _logger.LogWarning($"Login failed. Locked out: {result.IsLockedOut}, " +
                                         $"Requires 2FA: {result.RequiresTwoFactor}, " +
                                         $"Not Allowed: {result.IsNotAllowed}");
                    }
                }
                else
                {
                    _logger.LogWarning("User not found");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            else
            {
                _logger.LogWarning($"ModelState is invalid: {string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage))}");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUserModel
                {
                    UserName = model.Username,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    // Add user to "User" role
                    await _userManager.AddToRoleAsync(user, "User");

                    // Automatically sign in the user
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Map");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Map");
        }

        [HttpGet]
        public IActionResult CheckAuthStatus()
        {
            var status = new
            {
                IsAuthenticated = User.Identity?.IsAuthenticated ?? false,
                Username = User.Identity?.Name,
                Claims = User.Claims.Select(c => new { c.Type, c.Value }).ToList(),
                IsAdmin = User.IsInRole("Admin")
            };

            return Json(status);
        }
    }

}