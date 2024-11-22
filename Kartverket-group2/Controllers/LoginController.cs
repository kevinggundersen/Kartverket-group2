using Kartverket_group2.Models;
using Kartverket_group2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Kartverket_group2.Controllers
{
    /// <summary>
    /// Controller responsible for handling user authentication, registration, and password management.
    /// </summary>
    public class LoginController : Controller
    {
        private readonly SignInManager<ApplicationUserModel> _signInManager;
        private readonly UserManager<ApplicationUserModel> _userManager;
        private readonly ILogger<LoginController> _logger;
        private readonly IEmailService _emailService;

        /// <summary>
        /// Initializes a new instance of the LoginController with required services.
        /// </summary>
        public LoginController(
            SignInManager<ApplicationUserModel> signInManager,
            UserManager<ApplicationUserModel> userManager,
            ILogger<LoginController> logger,
            IEmailService emailService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _emailService = emailService;
        }

        /// <summary>
        /// Displays the login page.
        /// </summary>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Handles user login attempts and redirects based on role.
        /// </summary>
        /// <param name="model">Login credentials from form submission</param>
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Log the attempt
                _logger.LogInformation($"Login attempt for user: {model.EmailOrUsername}");

                // Attempt to find user by email or username
                var user = await _userManager.FindByEmailAsync(model.EmailOrUsername)
                    ?? await _userManager.FindByNameAsync(model.EmailOrUsername);

                if (user != null)
                {
                    _logger.LogInformation($"User found with ID: {user.Id}");

                    // Check if user is in Admin role before sign in
                    var isInAdminRole = await _userManager.IsInRoleAsync(user, "Admin");
                    _logger.LogInformation($"User is in Admin role: {isInAdminRole}");

                    // Attempt sign in
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    _logger.LogInformation($"Sign in result: {result.Succeeded}");
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User logged in successfully");

                        // Verify authentication state
                        var isAuthenticated = User.Identity?.IsAuthenticated ?? false;
                        _logger.LogInformation($"User.Identity.IsAuthenticated: {isAuthenticated}");

                        // Redirect based on role
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

                ModelState.AddModelError(string.Empty, "Feil brukernavn eller passord.");
            }
            else
            {
                _logger.LogWarning($"ModelState is invalid: {string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage))}");
            }

            return View(model);
        }

        /// <summary>
        /// Displays the user registration page.
        /// </summary>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Handles new user registration with automatic role assignment.
        /// </summary>
        /// <param name="model">Registration details from form submission</param>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Create new user instance
                var user = new ApplicationUserModel
                {
                    UserName = model.Username,
                    Email = model.Email
                };

                // Attempt to create user
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    // Assign default user role
                    await _userManager.AddToRoleAsync(user, "User");

                    // Automatically sign in new user
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Map");
                }

                // Add any errors to ModelState
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        /// <summary>
        /// Handles user logout.
        /// </summary>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Map");
        }

        /// <summary>
        /// API endpoint for checking user authentication status and roles.
        /// </summary>
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

        /// <summary>
        /// Password Reset Methods
        /// </summary>

        /// <summary>
        /// Displays forgot password form.
        /// </summary>
        public IActionResult ForgotPassword()
        {
            return View();
        }

        /// <summary>
        /// Displays confirmation page after password reset request.
        /// </summary>
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        /// <summary>
        /// Handles forgot password requests and sends reset email.
        /// </summary>
        /// <param name="model">Email address for password reset</param>
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    // Don't reveal user existence
                    return RedirectToAction("ForgotPasswordConfirmation");
                }

                // Generate password reset token and callback URL
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action("ResetPassword", "Login",
                    new { token, email = user.Email },
                    protocol: HttpContext.Request.Scheme);

                // Queue password reset email
                await _emailService.QueueEmailAsync(new EmailQueueMessage
                {
                    EmailType = EmailType.PasswordReset,
                    UserEmail = model.Email,
                    ResetLink = callbackUrl
                });

                return RedirectToAction("ForgotPasswordConfirmation");
            }

            return View(model);
        }

        /// <summary>
        /// Displays password reset form.
        /// </summary>
        /// <param name="token">Password reset token</param>
        /// <param name="email">User's email address</param>
        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            if (token == null || email == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordViewModel { Token = token, Email = email };
            return View(model);
        }

        /// <summary>
        /// Handles password reset requests.
        /// </summary>
        /// <param name="model">Password reset details including new password</param>
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal user existence
                return RedirectToAction("ResetPasswordConfirmation");
            }

            // Attempt password reset
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("ResetPasswordConfirmation");
            }

            // Add any errors to ModelState
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        /// <summary>
        /// Displays confirmation page after successful password reset.
        /// </summary>
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }
    }

}