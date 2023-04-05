using Learn1.Application.InterFaces.Context;
using Learn1.Application.InterFaces.FacadPatterns;
using Learn1.Application.Services.Products.FacadPattern;
using Learn1.Application.Services.Users.Commands.EditeUser;
using Learn1.Application.Services.Users.Commands.RegesterUser;
using Learn1.Application.Services.Users.Commands.RemoveUser;
using Learn1.Application.Services.Users.Commands.UserLogin;
using Learn1.Application.Services.Users.Commands.UserStatusChenge;
using Learn1.Application.Services.Users.Queries.GetUsers;
using Learn1.Persistence.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("LocalConnection");
// Add services to the container.
builder.Services.AddAuthentication(options =>
{
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = new PathString("/");
    options.ExpireTimeSpan = TimeSpan.FromMinutes(6.0);
});

builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();

builder.Services.AddScoped<IGetUsersServices, GetUsersService>();
builder.Services.AddScoped<IGetRolesService, GetRolesService>();
builder.Services.AddScoped<IRegesterUserService, RegesterUserServic>();
builder.Services.AddScoped<IRemoveUserService, RemoveUserService>();
builder.Services.AddScoped<IUserStatusChengeServic, UserStatusChengeServic>();
builder.Services.AddScoped<IEditeUserService, EditeUserService>();
builder.Services.AddScoped<IUserLoginService, UserLoginService>();
//FacadeInject
builder.Services.AddScoped<IProductFacad, ProductFacad>();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
    options.EnableDetailedErrors();
});


builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews();

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

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Users}/{action=Index}/{id?}"
          );

app.Run();
