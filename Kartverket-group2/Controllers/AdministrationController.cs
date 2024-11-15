using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kartverket_group2.Data;
using Kartverket_group2.Models;
using System.Threading.Tasks;
using Kartverket_group2.Services;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kartverket_group2.Controllers
{
    /// <summary>
    /// Controller responsible for administrative functions including user management,
    /// submission handling, and map data administration.
    /// </summary>
    public class AdministrationController : Controller
    {
        // Dependencies injected through constructor
        private readonly ApplicationDbContext _context;
        private readonly KartverketApiService _kartverketApiService;
        private readonly IEmailService _emailService;
        private readonly ILogger<AdministrationController> _logger;
        private readonly UserManager<ApplicationUserModel> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        /// <summary>
        /// Initializes a new instance of the AdministrationController with required services.
        /// </summary>
        public AdministrationController(
            ApplicationDbContext context, 
            KartverketApiService kartverketApiService, 
            ILogger<AdministrationController> logger,
            IEmailService emailService,
            UserManager<ApplicationUserModel> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _kartverketApiService = kartverketApiService;
            _logger = logger;
            _emailService = emailService;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        /// <summary>
        /// Displays the admin dashboard with filtered and paginated submissions.
        /// Only accessible by users with Admin role.
        /// </summary>
        /// <param name="statusFilter">Array of status values to filter by</param>
        /// <param name="municipalityMin">Minimum municipality number for range search</param>
        /// <param name="municipalityMax">Maximum municipality number for range search</param>
        /// <param name="municipalitySingle">Single municipality number to search for</param>
        /// <param name="municipalitySearchType">Type of municipality search (single/range)</param>
        /// <param name="page">Current page number</param>
        /// <param name="pageSize">Number of items per page</param>
        /// <param name="sortColumn">Column to sort by</param>
        /// <param name="sortDescending">Sort direction</param>
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Admin(
            string[] statusFilter,
            int? municipalityMin,
            int? municipalityMax,
            int? municipalitySingle,
            string municipalitySearchType = "single", // Set default value
            int page = 1,
            int pageSize = 25,
            string sortColumn = "Timestamp",
            bool sortDescending = true)
        {

            // Start with all submissions
            var query = _context.Submissions.AsQueryable();

            // Apply status filtering if specified
            if (statusFilter != null && statusFilter.Length > 0)
            {
                query = query.Where(s => statusFilter.Contains(s.Status));
            }

            // Apply municipality filtering based on search type
            if (!string.IsNullOrEmpty(municipalitySearchType))
            {
                if (municipalitySearchType == "single" && municipalitySingle.HasValue)
                {
                    string singleValue = municipalitySingle.Value.ToString().PadRight(4, '0');
                    query = query.Where(s => s.Municipalitynr == singleValue);
                }
                else if (municipalitySearchType == "range")
                {
                    if (municipalityMin.HasValue)
                    {
                        string minValue = municipalityMin.Value.ToString().PadRight(4, '0');
                        query = query.Where(s => string.Compare(s.Municipalitynr, minValue) >= 0);
                    }

                    if (municipalityMax.HasValue)
                    {
                        string maxValue = municipalityMax.Value.ToString().PadRight(4, '9');
                        query = query.Where(s => string.Compare(s.Municipalitynr, maxValue) <= 0);
                    }
                }
            }

            // Apply sorting based on selected column and direction
            query = sortColumn?.ToLower() switch
            {
                "id" => sortDescending ? query.OrderByDescending(s => s.Id) : query.OrderBy(s => s.Id),
                "userid" => sortDescending ? query.OrderByDescending(s => s.UserId) : query.OrderBy(s => s.UserId),
                "comment" => sortDescending ? query.OrderByDescending(s => s.Comment) : query.OrderBy(s => s.Comment),
                "timestamp" => sortDescending ? query.OrderByDescending(s => s.Timestamp) : query.OrderBy(s => s.Timestamp),
                "status" => sortDescending ? query.OrderByDescending(s => s.Status) : query.OrderBy(s => s.Status),
                "municipalitynr" => sortDescending ? query.OrderByDescending(s => s.Municipalitynr) : query.OrderBy(s => s.Municipalitynr),
                _ => query.OrderBy(s => s.Id)
            };

            // Get total count for pagination
            int totalItems = await query.CountAsync();

            // Apply pagination
            var submissions = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Prepare view model with all necessary data
            var viewModel = new AdminViewModel
            {
                Submissions = submissions,
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems,
                CurrentSortColumn = sortColumn,
                SortDescending = sortDescending,
                StatusFilter = statusFilter,
                MunicipalityMin = municipalityMin,
                MunicipalityMax = municipalityMax,
                MunicipalitySingle = municipalitySingle,
                MunicipalitySearchType = municipalitySearchType
            };

            return View(viewModel);
        }


        /// <summary>
        /// Handles the submission of shape data from authorized users.
        /// Processes GeoJSON data and determines the municipality number based on coordinates.
        /// </summary>
        /// <param name="shapeData">JSON string containing shape data and metadata</param>
        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> SaveShapes(string shapeData)
        {
            if (string.IsNullOrEmpty(shapeData))
            {
                return RedirectToAction("Index", new { message = "No shape data received." });
            }

            try
            {
                // Deserialize the submitted shape data
                var submission = JsonSerializer.Deserialize<Submission>(shapeData);

                // Get the first feature to determine municipality
                var firstFeature = submission.GeoJsonData.Features.FirstOrDefault();
                
                if (firstFeature != null)
                {
                    try
                    {
                        // Extract coordinates and get municipality number from Kartverket API
                        var (longitude, latitude) = GeoJsonCoordinateExtractor.ExtractFirstCoordinates(firstFeature.Geometry);
                        submission.Municipalitynr = await _kartverketApiService.GetMunicipalityNumberAsync(longitude, latitude);
                    }
                    catch (HttpRequestException ex)
                    {
                        _logger.LogError(ex, "Error fetching municipality data from Kartverket API");
                        submission.Municipalitynr = "Unable to determine";
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error extracting coordinates from geometry");
                        submission.Municipalitynr = "Unable to determine";
                    }
                }

                // Set the user ID from the current user's claims
                submission.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Save the submission to the database
                _context.Submissions.Add(submission);
                await _context.SaveChangesAsync();

                return RedirectToAction("Confirmation", "Map");
            }
            catch (JsonException ex)
            {
                _logger.LogError(ex, "Error deserializing submission data");
                return RedirectToAction("Index", new { message = "Error processing shape data." });
            }
        }

        /// <summary>
        /// Displays detailed information for a specific submission.
        /// Only accessible by Admin users.
        /// </summary>
        /// <param name="id">The ID of the submission to view</param>
        /// <returns>View containing submission details or NotFound if submission doesn't exist</returns>
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ViewSubmissionDetails(long id)
        {
            var submission = await _context.Submissions.FindAsync(id);
            if (submission == null)
            {
                return NotFound();
            }
            return View(submission);
        }

        /// <summary>
        /// Updates the status of a submission and optionally sends an email notification to the user.
        /// Only accessible by Admin users.
        /// </summary>
        /// <param name="id">The ID of the submission to update</param>
        /// <param name="status">The new status to set</param>
        /// <param name="comment">Comment associated with the status update</param>
        /// <param name="skipEmail">Whether to skip sending email notification</param>
        /// <param name="adminComment">Administrative comment about the status change</param>
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateStatus(long id, string status, string comment, bool skipEmail, string adminComment)
        {
            // Find the submission
            var submission = await _context.Submissions.FindAsync(id);
            if (submission == null)
            {
                return NotFound();
            }

            // Store old status for comparison
            var oldStatus = submission.Status;
            submission.Status = status;
            submission.AdminComment = adminComment;
            await _context.SaveChangesAsync();

            if (!skipEmail && oldStatus != status)
            {
                var user = await _userManager.FindByIdAsync(submission.UserId);

                // Send email notification if enabled and status has changed
                if (user != null)
                {
                    try
                    {
                        // Queue email notification
                        await _emailService.QueueEmailAsync(new EmailQueueMessage
                        {
                            EmailType = EmailType.StatusUpdate,
                            UserEmail = user.Email,
                            SubmissionId = submission.Id.ToString(),
                            NewStatus = status,
                            AdminComment = adminComment
                        });

                        _logger.LogInformation("Email queued for sending to {UserEmail}", user.Email);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Failed to queue email for submission {SubmissionId}", id);
                    }
                }
            }

            return RedirectToAction("ViewSubmissionDetails", new { id = id });
        }


        /// <summary>
        /// Deletes a submission from the database.
        /// Only accessible by Admin users.
        /// </summary>
        /// <param name="id">The ID of the submission to delete</param>
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult DeleteSubmission(long id)
        {
            var submission = _context.Submissions.Find(id);
            if (submission != null)
            {
                _context.Submissions.Remove(submission);
                _context.SaveChanges();
            }
            return RedirectToAction("Admin");
        }

        /// <summary>
        /// Helper class for extracting coordinates from different types of GeoJSON geometries.
        /// </summary>
        public class GeoJsonCoordinateExtractor
        {

            /// <summary>
            /// Extracts the first set of coordinates from any supported GeoJSON geometry type.
            /// </summary>
            /// <param name="geometry">The GeoJSON geometry object</param>
            /// <returns>Tuple containing longitude and latitude</returns>
            public static (double longitude, double latitude) ExtractFirstCoordinates(GeoJsonGeometry geometry)
            {
                return geometry.Type switch
                {
                    "Point" => ExtractPointCoordinates(geometry.Coordinates),
                    "LineString" => ExtractLineStringCoordinates(geometry.Coordinates),
                    "Polygon" => ExtractPolygonCoordinates(geometry.Coordinates),
                    "MultiPolygon" => ExtractMultiPolygonCoordinates(geometry.Coordinates),
                    "MultiLineString" => ExtractMultiLineStringCoordinates(geometry.Coordinates),
                    "MultiPoint" => ExtractMultiPointCoordinates(geometry.Coordinates),
                    _ => throw new ArgumentException($"Unsupported geometry type: {geometry.Type}")
                };
            }

            // Helper methods for extracting coordinates from specific geometry types
            private static (double longitude, double latitude) ExtractPointCoordinates(object coordinates)
            {
                var coords = ((JsonElement)coordinates).EnumerateArray().ToArray();
                return (coords[0].GetDouble(), coords[1].GetDouble());
            }

            private static (double longitude, double latitude) ExtractLineStringCoordinates(object coordinates)
            {
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                return ExtractPointCoordinates(coordArray.First());
            }

            // Extract first point from exterior ring of polygon
            private static (double longitude, double latitude) ExtractPolygonCoordinates(object coordinates)
            {
                // Get the first ring (exterior ring)
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                var firstRing = coordArray.First();
                // Get the first point of the ring
                var firstPoint = firstRing.EnumerateArray().First();
                return ExtractPointCoordinates(firstPoint);
            }

            private static (double longitude, double latitude) ExtractMultiPolygonCoordinates(object coordinates)
            {
                // Get the first polygon
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                return ExtractPolygonCoordinates(coordArray.First());
            }

            private static (double longitude, double latitude) ExtractMultiLineStringCoordinates(object coordinates)
            {
                // Get the first linestring
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                return ExtractLineStringCoordinates(coordArray.First());
            }

            private static (double longitude, double latitude) ExtractMultiPointCoordinates(object coordinates)
            {
                // Get the first point
                var coordArray = ((JsonElement)coordinates).EnumerateArray();
                return ExtractPointCoordinates(coordArray.First());
            }
        }

        /// <summary>
        /// Displays a map view of all submissions.
        /// Only accessible by Admin users.
        /// </summary>
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MapView()
        {
            var submissions = await _context.Submissions.ToListAsync();
            return View(submissions);
        }

        /// <summary>
        /// Generates GeoJSON representation of all submissions for map display.
        /// Only accessible by Admin users.
        /// </summary>
        /// <returns>JSON result containing GeoJSON feature collection</returns>
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetSubmissionsGeoJson()
        {
            try
            {
                // Fetch all submissions from database
                var submissions = await _context.Submissions.ToListAsync();
                _logger.LogInformation($"Found {submissions.Count} submissions");

                var features = new List<object>();

                // Process each submission
                foreach (var submission in submissions)
                {
                    _logger.LogInformation($"Processing submission {submission.Id}");

                    if (submission.GeoJsonData?.Features == null)
                    {
                        _logger.LogWarning($"Submission {submission.Id} has no features");
                        continue;
                    }

                    // Convert each feature to a point feature with submission metadata
                    foreach (var feature in submission.GeoJsonData.Features)
                    {
                        try
                        {
                            // Extract coordinates for the marker
                            var (longitude, latitude) = GeoJsonCoordinateExtractor.ExtractFirstCoordinates(feature.Geometry);

                            _logger.LogInformation($"Extracted coordinates for submission {submission.Id}: ({longitude}, {latitude})");

                            // Create feature with properties
                            features.Add(new
                            {
                                type = "Feature",
                                geometry = new
                                {
                                    type = "Point",
                                    coordinates = new[] { longitude, latitude }
                                },
                                properties = new
                                {
                                    submissionId = submission.Id,
                                    comment = submission.Comment ?? "",
                                    timestamp = submission.Timestamp,
                                    status = submission.Status ?? "Unknown",
                                    municipalityNr = submission.Municipalitynr ?? "Unknown",
                                    geometryType = feature.Geometry.Type
                                }
                            });
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, $"Error processing feature for submission {submission.Id}");
                        }
                    }
                }

                // Create final GeoJSON object
                var geoJson = new
                {
                    type = "FeatureCollection",
                    features = features
                };

                _logger.LogInformation($"Returning GeoJSON with {features.Count} features");
                return Json(geoJson);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating GeoJSON");
                return StatusCode(500, new { error = "Error generating GeoJSON" });
            }
        }

        /// <summary>
        /// Displays the user creation form with available roles.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {
            // Prepare view model with list of available roles
            var model = new CreateUserViewModel
            {
                Roles = _roleManager.Roles.Select(r => new SelectListItem
                {
                    Value = r.Name,
                    Text = r.Name
                }).ToList()
            };

            return View(model);
        }

        /// <summary>
        /// Handles the creation of a new user with specified roles.
        /// </summary>
        /// <param name="model">View model containing user and role information</param>
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Create new user
                var user = new ApplicationUserModel
                {
                    UserName = model.Username,
                    Email = model.Email
                };

                // Attempt to create user
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // Assign selected roles to user
                    if (model.SelectedRoles != null && model.SelectedRoles.Any())
                    {
                        await _userManager.AddToRolesAsync(user, model.SelectedRoles);
                    }

                    return RedirectToAction("UserList");
                }

                // Add any errors to ModelState
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            model.Roles = _roleManager.Roles.Select(r => new SelectListItem
            {
                Value = r.Name,
                Text = r.Name
            }).ToList();

            return View(model);
        }

        /// <summary>
        /// Displays a list of users, optionally filtered by role.
        /// </summary>
        /// <param name="role">Optional role to filter users by</param>
        [HttpGet]
        public async Task<IActionResult> UserList(string role)
        {
            // Get users based on role filter
            var users = string.IsNullOrEmpty(role)
                ? await _userManager.Users.ToListAsync()
                : await _userManager.GetUsersInRoleAsync(role);

            // Prepare view model
            var model = new UserListViewModel
            {
                Users = users.ToList(),
                Roles = _roleManager.Roles.Select(r => r.Name).ToList(),
                SelectedRole = role,
                UserManager = _userManager // Pass UserManager for role checks in view
            };

            return View(model);
        }
    }
}