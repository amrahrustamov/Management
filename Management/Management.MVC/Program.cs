using Management.DataAccess.Contexts;
using Management.MVC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//Services
builder.Services.AddControllersWithViews();

builder.Services.AddServices();

/*var connectionStr = builder.Configuration.GetConnectionString("Default");
//var connectionStr2 = builder.Configuration.GetSection("CustomConnectionStr").ToString();
//var connectionStr3 = builder.Configuration["CustomConnectionStr"];

builder.Services.AddDbContext<ManagementDbContext>(opt =>
{
    opt.UseSqlServer(connectionStr);
});*/



var app = builder.Build();

//Middleware
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}"
    );

app.Run();
