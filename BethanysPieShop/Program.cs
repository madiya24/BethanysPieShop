var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Add services to the container.

var app = builder.Build();

app.UseStaticFiles(); // Enable serving static files
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Enable detailed error pages in development
}

app.MapDefaultControllerRoute(); // Map default controller route 


app.Run();
