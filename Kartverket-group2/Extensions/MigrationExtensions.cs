// Extensions/MigrationExtensions.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Kartverket_group2.Extensions
{
    /// <summary>
    /// Provides extension methods for database migration operations.
    /// </summary>
    public static class MigrationExtensions
    {
        /// <summary>
        /// Applies pending database migrations for the specified DbContext type during application startup.
        /// </summary>
        /// <typeparam name="T">The type of DbContext to migrate</typeparam>
        /// <param name="host">The IHost instance being configured</param>
        /// <returns>The same IHost instance for chaining</returns>
        /// <exception cref="Exception">Thrown when migration fails</exception>
        public static IHost MigrateDatabase<T>(this IHost host) where T : DbContext
        {
            // Create a new scope to resolve scoped services
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    // Get the DbContext instance
                    var db = services.GetRequiredService<T>();

                    // Apply any pending migrations
                    db.Database.Migrate();

                    // Log successful migration
                    var logger = services.GetRequiredService<ILogger<T>>();
                    logger.LogInformation("Database migrated successfully");
                }
                catch (Exception ex)
                {
                    // Log migration failure and rethrow
                    var logger = services.GetRequiredService<ILogger<T>>();
                    logger.LogError(ex, "An error occurred while migrating the database");
                    throw;
                }
            }
            return host;
        }
    }
}