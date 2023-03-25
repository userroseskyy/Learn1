using Learn1.Application.InterFaces.Context;
using Learn1.Application.Services.Users.Queries.GetUsers;
using Learn1.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("LocalConnection");
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();

builder.Services.AddScoped<IGetUsersServices, GetUsersService>();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
    options.EnableDetailedErrors();
});

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
app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Users}/{action=Index}/{id?}"
          );

app.Run();
