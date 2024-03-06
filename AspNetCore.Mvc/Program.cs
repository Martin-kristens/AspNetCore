using Infrastrucutre.Contexts;
using Infrastrucutre.Entities;
using Infrastrucutre.Repositories;
using Infrastrucutre.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRouting(x => x.LowercaseUrls = true);
builder.Services.AddControllersWithViews();

builder.Services.AddDefaultIdentity<UserEntity>(x =>
{
    x.User.RequireUniqueEmail = true;
    x.SignIn.RequireConfirmedAccount = false;
}).AddEntityFrameworkStores<DataContext>();


builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddScoped<AddressRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<UserSerivce>();
builder.Services.AddScoped<UserDetailsService>();



var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
