using BethanysPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPieRepository, MockPieRepository>(); // we use AddScoped to create a new instance of MockPieRepository for each HTTP request. This allows us to have a fresh instance of the repository for each request, which is useful for testing and development purposes.
builder.Services.AddScoped<ICategoryRepository, MoCkCategoryRepository>(); // we use AddScoped to create a new instance of MockCategoryRepository for each HTTP request. This allows us to have a fresh instance of the repository for each request, which is useful for testing and development purposes.
builder.Services.AddControllersWithViews(); // Add services to the container.

var app = builder.Build();

app.UseStaticFiles(); // Enable serving static files
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Enable detailed error pages in development
}

app.MapDefaultControllerRoute(); // Map default controller route 


app.Run();
