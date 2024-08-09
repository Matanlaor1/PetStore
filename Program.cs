using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PetStore.Data;
using PetStore.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<MyContext>();
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}


app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute("Default", "{controller=home}/{action=index}/{id?}");

app.Run();