using Microsoft.EntityFrameworkCore;
using crudProveedorMVCCORE.Models;
using Microsoft.AspNetCore.Components.Forms;
using crudProveedorMVCCORE.Models.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BDAUTOS")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Marcas}/{action=Index}/{id?}");

app.Run();
