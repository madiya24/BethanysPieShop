using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPieRepository, PieRepository>(); // we use AddScoped to create a new instance of MockPieRepository for each HTTP request. This allows us to have a fresh instance of the repository for each request, which is useful for testing and development purposes.
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); 
builder.Services.AddControllersWithViews(); // Add services to the container.

builder.Services.AddDbContext<BethanysPieShopDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("BethanysPieShopDbContextConnection"));
}); // AddDbContext is used to register the BethanysPieShopDbContext with the dependency injection container. It takes a lambda expression that configures the DbContext options. In this case, we are using UseSqlServer to specify that we want to use SQL Server as our database provider, and we are getting the connection string from the configuration file (appsettings.json) using GetConnectionString method.

var app = builder.Build();

app.UseStaticFiles(); // Enable serving static files
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Enable detailed error pages in development
}

app.MapDefaultControllerRoute(); // Map default controller route 


app.Run();
