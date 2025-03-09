using Microsoft.EntityFrameworkCore;
using Webshop.Data;

var builder = WebApplication.CreateBuilder(args);

// MySQL adatbázis
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 31)))); // Állítsd be a MySQL verzióját

// Alapértelmezett szolgáltatások hozzáadása (MVC vagy Razor Pages)
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

// Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
