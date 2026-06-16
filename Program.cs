using Microsoft.EntityFrameworkCore;
using SKCatalog.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add EF Core DI
builder.Services.AddDbContext<SKCatalogContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("SKCatalogContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=SKClasses}/{action=Index}/{id?}");

app.Run();
