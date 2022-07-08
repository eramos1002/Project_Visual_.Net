

using Microsoft.EntityFrameworkCore;
using MySecondProject.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");
//builder.Services.AddDbContext<OfficeDb>(Options=>
//  Options.UseNpgsql())
//Install-Package Npgsql.EntityFrameworkCore.PostgreSQL
builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<Contexto>(options =>
    //options.UseNpgsql("Server=127.0.0.1;Port=5432;User Id=postgres;Password=root;Database=test;"));
    options.UseNpgsql(connectionString));


var app = builder.Build();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
