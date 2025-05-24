using Microsoft.AspNetCore.Mvc;
using _367_project_repo_destroyersofevil.Services;

namespace _367_project_repo_destroyersofevil.Controllers
{
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
            return View(exercises);
        }
    }
}
