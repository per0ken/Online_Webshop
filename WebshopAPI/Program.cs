using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Webshop.Data;
using WebshopAPI.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("frontend", policy =>
    {
        policy.WithOrigins("http://localhost:3000")  // Engedélyezi a React frontend domainjét
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// MySQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 31)))); // Állítsd be a MySQL verzióját

// Identity
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Alapértelmezett szolgáltatások hozzáadása (MVC vagy Razor Pages)
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseCors("frontend");

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();

// Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
