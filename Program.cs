using PhoneBook.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

app.MapControllerRoute(
"default",
"{controller=Home}/{action=Index}/{id?}");


app.Run();
