using Microsoft.AspNetCore.Mvc;
using _367_project_repo_destroyersofevil.Services;

public class WorkoutController : Controller
{
    private readonly ExerciseApiService _exerciseService;

    public WorkoutController(ExerciseApiService exerciseService)
    {
        _exerciseService = exerciseService;
    }

    public async Task<IActionResult> Index()
    {
        var exercises = await _exerciseService.GetExercisesAsync();

        if (exercises == null || !exercises.Any())
        {
            
            ViewBag.Error = "No exercises found from the API.";
        }

        return View(exercises);
    }
}

