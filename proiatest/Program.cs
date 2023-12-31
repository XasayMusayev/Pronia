using Microsoft.EntityFrameworkCore;
using proiatest.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProniaDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

var app = builder.Build();

app.MapControllerRoute("default","{controller=home}/{action=index}/{id?}");


app.UseStaticFiles();
app.Run();
