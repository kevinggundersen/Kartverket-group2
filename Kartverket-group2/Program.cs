
using Kartverket_group2.Data;
using Kartverket_group2.Extensions;
using Kartverket_group2.Models;
using Kartverket_group2.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<KartverketApiService>();
builder.Services.AddScoped<IKartverketApiService, KartverketApiService>();
builder.Services.AddLogging();
builder.Services.AddIdentity<ApplicationUserModel, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddScoped<IEmailService, EmailService>();

// Register the SmtpClient configuration
builder.Services.AddSingleton<SmtpClient>(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    return new SmtpClient
    {
        Host = configuration["Email:SmtpServer"],
        Port = int.Parse(configuration["Email:Port"]),
        Credentials = new System.Net.NetworkCredential(
            configuration["Email:Username"],
            configuration["Email:Password"]
        ),
        EnableSsl = true
    };
});

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.LoginPath = "/Home/Welcome";
    options.AccessDeniedPath = "/Login/AccessDenied";
    options.SlidingExpiration = true;
});

// Use the DefaultConnection string for both development and Docker
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")),
        mySqlOptions =>
        {
            mySqlOptions.EnableRetryOnFailure(
                maxRetryCount: 10,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
        }
    )
);

var app = builder.Build();

try
{
    app.MigrateDatabase<ApplicationDbContext>();
}
catch (Exception ex)
{
    // Log the error and handle it appropriately
    var logger = app.Services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occurred while migrating the database");

    // Optionally, you might want to:
    // 1. Retry the migration after a delay
    // 2. Exit the application
    // 3. Continue running but mark the health check as unhealthy
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services).Wait();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Map}/{action=Index}/{id?}");

app.Run();