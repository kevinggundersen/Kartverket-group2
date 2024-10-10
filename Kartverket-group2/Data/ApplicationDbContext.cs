using Microsoft.EntityFrameworkCore;
using Kartverket_group2.Models;
using System.Text.Json;

namespace Kartverket_group2.Data
{
    public class ApplicationDbContext : DbContext
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
        }
    }
}