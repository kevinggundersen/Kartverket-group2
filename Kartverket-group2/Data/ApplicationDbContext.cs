using Microsoft.EntityFrameworkCore;
using Kartverket_group2.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Globalization;

namespace Kartverket_group2.Data
{
    /// <summary>
    /// Database context class that handles database operations and schema configuration.
    /// Inherits from IdentityDbContext to support ASP.NET Core Identity.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUserModel>
    {
        /// <summary>
        /// Initializes database context with provided options.
        /// </summary>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// DbSet for accessing and managing Submission entities.
        /// </summary>
        public DbSet<Submission> Submissions { get; set; }

        /// <summary>
        /// Configures the database model and seeds initial data.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call base configuration for Identity tables
            base.OnModelCreating(modelBuilder);

            // Configure GeoJsonData property to be stored as serialized JSON in database
            modelBuilder.Entity<Submission>()
                .Property(s => s.GeoJsonData)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<GeoJsonFeatureCollection>(v, (JsonSerializerOptions)null)
                );

            // Generate test data for development/testing
            var submissions = new List<Submission>();
            for (int i = 1; i <= 100; i++)
            {
                submissions.Add(new Submission
                {
                    Id = i,
                    Comment = $"Test submission {i}",

                    // Create timestamps with decreasing dates for realistic test data
                    Timestamp = DateTime.Parse(
                    DateTime.UtcNow.AddDays(-i).ToString("yyyy-MM-ddTHH:mm:ss"), 
                    CultureInfo.InvariantCulture),
                    // Rotate through different status values
                    Status = i % 3 == 0 ? "Behandlet" : (i % 2 == 0 ? "Under behandling" : "Ikke påbegynt"),
                    // Generate sequential municipality numbers
                    Municipalitynr = $"{3000 + i}",
                    // Create test GeoJSON data with point features
                    GeoJsonData = new GeoJsonFeatureCollection
                    {
                        Type = "FeatureCollection",
                        // Rotate through different map layers
                        ActiveTileLayer = i % 3 == 0 ? "Standard" : (i % 2 == 0 ? "Turkart" : "Sattelitt"),
                        Features = new List<GeoJsonFeature>
                            {
                                new GeoJsonFeature
                                {
                                    Type = "Feature",
                                     // Generate point geometry with incrementing coordinates
                                    Geometry = new GeoJsonGeometry
                                    {
                                        Type = "Point",
                                        Coordinates = new double[] { 8.0 + (i * 0.11234), 58.0 + (i * 0.11757) }
                                    },
                                    Properties = new GeoJsonProperties
                                    {
                                        Id = i,
                                        Type = "Markør",
                                        Comment = $"Feature comment {i}",
                                        Radius = i * 10.5
                                    }
                                }
                            }
                    }
                });
            }
            // Seed the test data
            modelBuilder.Entity<Submission>().HasData(submissions);
        }
    }
}
