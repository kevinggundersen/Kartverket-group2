using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Kartverket_group2.Data;
using Kartverket_group2.Models;
using Kartverket_group2.Services;
using Kartverket_group2.Controllers;

namespace Kartverket_group2.Tests
{
    public class AdministrationControllerTests
    {
        private readonly Mock<DbSet<Submission>> _mockSubmissions;
        private readonly ApplicationDbContext _context;
        private readonly Mock<IKartverketApiService> _mockKartverketApi;  // Changed to interface
        private readonly Mock<ILogger<AdministrationController>> _mockLogger;
        private readonly Mock<IEmailService> _mockEmailService;
        private readonly Mock<UserManager<ApplicationUserModel>> _mockUserManager;
        private readonly Mock<RoleManager<IdentityRole>> _mockRoleManager;
        private readonly AdministrationController _controller;

        public AdministrationControllerTests()
        {
            // Create mock DbSet
            _mockSubmissions = new Mock<DbSet<Submission>>();

            // Create DbContextOptions
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())  // Use unique name for each test
                .Options;

            // Create actual context with in-memory database
            _context = new ApplicationDbContext(options);

            // Setup other mocks
            _mockKartverketApi = new Mock<IKartverketApiService>();  // Changed to interface
            _mockLogger = new Mock<ILogger<AdministrationController>>();
            _mockEmailService = new Mock<IEmailService>();
            _mockUserManager = MockUserManager<ApplicationUserModel>();
            _mockRoleManager = MockRoleManager();

            // Setup controller with mock user identity
            _controller = new AdministrationController(
                _context,
                _mockKartverketApi.Object,
                _mockLogger.Object,
                _mockEmailService.Object,
                _mockUserManager.Object,
                _mockRoleManager.Object
            );

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, "test-user-id"),
            }));

            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };
        }

        [Fact]
        public async Task SaveShapes_WithValidData_SavesSubmissionAndRedirects()
        {
            // Arrange
            var validSubmission = new Submission
            {
                Comment = "Test submission",
                Timestamp = DateTime.UtcNow,
                GeoJsonData = new GeoJsonFeatureCollection
                {
                    Type = "FeatureCollection",
                    Features = new List<GeoJsonFeature>
                    {
                        new GeoJsonFeature
                        {
                            Type = "Feature",
                            Geometry = new GeoJsonGeometry
                            {
                                Type = "Point",
                                Coordinates = new double[] { 10.0, 60.0 }
                            },
                            Properties = new GeoJsonProperties
                            {
                                Id = 1,
                                Type = "Point",
                                Comment = "Test point",
                                AddedAt = DateTime.UtcNow.ToString("o"),
                                LastEdited = DateTime.UtcNow.ToString("o")
                            }
                        }
                    },
                    ActiveTileLayer = "default"
                },
                Status = "Ikke påbegynt"
            };

            var shapeData = JsonSerializer.Serialize(validSubmission);

            _mockKartverketApi
                .Setup(k => k.GetMunicipalityNumberAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync("0301");

            // Act
            var result = await _controller.SaveShapes(shapeData);

            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Confirmation", redirectResult.ActionName);
            Assert.Equal("Map", redirectResult.ControllerName);

            var savedSubmission = await _context.Submissions.FirstOrDefaultAsync();
            Assert.NotNull(savedSubmission);
            Assert.Equal("0301", savedSubmission.Municipalitynr);
        }

        [Fact]
        public async Task SaveShapes_WhenKartverketApiFailsWithHttpException_SetsUnableToDetermine()
        {
            // Arrange
            var validSubmission = new Submission
            {
                Comment = "Test submission",
                Timestamp = DateTime.UtcNow,
                GeoJsonData = new GeoJsonFeatureCollection
                {
                    Type = "FeatureCollection",
                    Features = new List<GeoJsonFeature>
                    {
                        new GeoJsonFeature
                        {
                            Type = "Feature",
                            Geometry = new GeoJsonGeometry
                            {
                                Type = "Point",
                                Coordinates = new double[] { 10.0, 60.0 }
                            },
                            Properties = new GeoJsonProperties
                            {
                                Id = 1,
                                Type = "Point",
                                Comment = "Test point",
                                AddedAt = DateTime.UtcNow.ToString("o"),
                                LastEdited = DateTime.UtcNow.ToString("o")
                            }
                        }
                    },
                    ActiveTileLayer = "default"
                },
                Status = "Ikke påbegynt"
            };

            var shapeData = JsonSerializer.Serialize(validSubmission);

            _mockKartverketApi
                .Setup(k => k.GetMunicipalityNumberAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ThrowsAsync(new HttpRequestException("API Error"));

            // Act
            var result = await _controller.SaveShapes(shapeData);

            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Confirmation", redirectResult.ActionName);

            var submission = await _context.Submissions.FirstOrDefaultAsync();
            Assert.NotNull(submission);
            Assert.Equal("Unable to determine", submission.Municipalitynr);
        }

        [Fact]
        public async Task SaveShapes_WithNullData_RedirectsWithError()
        {
            // Arrange
            string shapeData = null;

            // Act
            var result = await _controller.SaveShapes(shapeData);

            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectResult.ActionName);
            Assert.Equal("No shape data received.", redirectResult.RouteValues["message"]);
        }

        [Fact]
        public async Task SaveShapes_WithInvalidJson_RedirectsWithError()
        {
            // Arrange
            var invalidJson = "{invalid-json}";

            // Act
            var result = await _controller.SaveShapes(invalidJson);

            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectResult.ActionName);
            Assert.Equal("Error processing shape data.", redirectResult.RouteValues["message"]);
        }

        // Helper method to mock UserManager
        private static Mock<UserManager<TUser>> MockUserManager<TUser>() where TUser : class
        {
            var store = new Mock<IUserStore<TUser>>();
            var mgr = new Mock<UserManager<TUser>>(
                store.Object,
                null, null, null, null, null, null, null, null);
            mgr.Object.UserValidators.Add(new UserValidator<TUser>());
            mgr.Object.PasswordValidators.Add(new PasswordValidator<TUser>());
            return mgr;
        }

        // Helper method to mock RoleManager
        private static Mock<RoleManager<IdentityRole>> MockRoleManager()
        {
            var store = new Mock<IRoleStore<IdentityRole>>();
            var mgr = new Mock<RoleManager<IdentityRole>>(
                store.Object, null, null, null, null);
            return mgr;
        }

        public void Dispose()
        {
            // Clean up the in-memory database after each test
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}