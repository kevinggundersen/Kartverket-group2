using Microsoft.EntityFrameworkCore;
using Kartverket_group2.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Kartverket_group2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUserModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Submission> Submissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Submission>()
                .Property(s => s.GeoJsonData)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<GeoJsonFeatureCollection>(v, (JsonSerializerOptions)null)
                );

        // Seed data
        var submissions = new List<Submission>();

        for (int i = 1; i <= 100; i++)
        {
            submissions.Add(new Submission
            {
                Id = i,
                Comment = $"Test submission {i}",
                Timestamp = DateTime.UtcNow.AddDays(-i).ToString("o"),
                Status = i % 3 == 0 ? "Akseptert" : (i % 2 == 0 ? "Under arbeid" : "Uåpnet"),
                Municipalitynr = $"{3000 + i}",
                GeoJsonData = new GeoJsonFeatureCollection
                {
                    Type = "FeatureCollection",
                    ActiveTileLayer = i % 3 == 0 ? "Standard" : (i % 2 == 0 ? "Turkart" : "Sattelitt"),
                    Features = new List<GeoJsonFeature>
                {
                    new GeoJsonFeature
                    {
                        Type = "Feature",
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
                            AddedAt = DateTime.UtcNow.AddDays(-i).ToString("o"),
                            LastEdited = DateTime.UtcNow.AddHours(-i).ToString("o"),
                            Radius = i * 10.5
                        }
                    }
                }
                }
            });
        }

        modelBuilder.Entity<Submission>().HasData(submissions);
        }
    }
}