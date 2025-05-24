using _367_project_repo_destroyersofevil.Services;

var builder = WebApplication.CreateBuilder(args);

// Register your ExerciseApiService with HttpClient here
builder.Services.AddHttpClient<ExerciseApiService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
