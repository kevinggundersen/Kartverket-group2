using Kartverket_group2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

public static class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUserModel>>();

        // Ensure roles exist
        string[] roleNames = { "Admin", "User" };
        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        // Get admin credentials from environment variables
        var adminEmail = Environment.GetEnvironmentVariable("ADMIN_EMAIL");
        var adminPassword = Environment.GetEnvironmentVariable("ADMIN_PASSWORD");

        if (string.IsNullOrEmpty(adminEmail) || string.IsNullOrEmpty(adminPassword))
        {
            throw new Exception("Admin credentials are not set in environment variables.");
        }

        // Find or create admin user
        var user = await userManager.FindByEmailAsync(adminEmail);

        if (user == null)
        {
            // Create new admin user if doesn't exist
            var adminUser = new ApplicationUserModel
            {
                UserName = adminEmail,
                Email = adminEmail
            };

            var createAdminUser = await userManager.CreateAsync(adminUser, adminPassword);
            if (createAdminUser.Succeeded)
            {
                user = adminUser; // Set user to the newly created admin for role management
            }
            else
            {
                throw new Exception("Failed to create admin user: " +
                    string.Join(", ", createAdminUser.Errors.Select(e => e.Description)));
            }
        }

        // Ensure user has all required roles
        foreach (var roleName in roleNames)
        {
            if (!await userManager.IsInRoleAsync(user, roleName))
            {
                var result = await userManager.AddToRoleAsync(user, roleName);
                if (!result.Succeeded)
                {
                    throw new Exception($"Failed to add role {roleName} to admin user: " +
                        string.Join(", ", result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}