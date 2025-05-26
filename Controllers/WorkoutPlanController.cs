using Microsoft.AspNetCore.Mvc;
using _367_project_repo_destroyersofevil.Models;
using _367_project_repo_destroyersofevil.Services;

namespace _367_project_repo_destroyersofevil.Controllers
{
    public class WorkoutPlanController : Controller
    {
        private readonly ExerciseApiService _exerciseService;

        public WorkoutPlanController(ExerciseApiService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkoutPlanViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var allExercises = await _exerciseService.GetExercisesAsync();

            // Simple filter by equipment and number of days
           var equipmentList = model.AvailableEquipment?
                .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Select(e => e.ToLower())
                .ToList() ?? new List<string>();

            var matchingExercises = allExercises
                .Where(e =>
            !string.IsNullOrEmpty(e.Equipment) &&
                equipmentList.Any(eq => e.Equipment.ToLower().Contains(eq)))
                .Take(model.WorkoutDaysPerWeek * 3)
                .ToList();

            model.GeneratedExercises = matchingExercises;


            return View("Result", model);
        }
    }
}
