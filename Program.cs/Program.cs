using _367_project_repo_destroyersofevil.Data;
using Microsoft.EntityFrameworkCore;
using _367_project_repo_destroyersofevil.Services;
using Microsoft.AspNetCore.Authentication.Cookies;   // ← Add this!

var builder = WebApplication.CreateBuilder(args);

// 1) Data & MVC
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddControllersWithViews();

// 2) External API service
builder.Services.AddHttpClient<ExerciseApiService>();

// 3) Authentication & Authorization
builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath  = "/Account/Login";
        options.LogoutPath = "/Account/Logout";
    });

builder.Services.AddAuthorization();

var app = builder.Build();

// 4) Error pages & static files
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
//app.UseHttpsRedirection();
app.UseStaticFiles();

// 5) Routing + Auth (in this exact order)
app.UseRouting();           // ← first
app.UseAuthentication();    // ← then authentication
app.UseAuthorization();     // ← then authorization

// 6) Map controllers
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

