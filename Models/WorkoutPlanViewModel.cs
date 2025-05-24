using System.ComponentModel.DataAnnotations;

namespace _367_project_repo_destroyersofevil.Models
{
    public class WorkoutPlanViewModel
    {
        [Required(ErrorMessage = "Please select a fitness goal.")]
        public FitnessGoal? Goal { get; set; }

        [Required(ErrorMessage = "Please enter available equipment.")]
        public string? AvailableEquipment { get; set; }

        [Range(1, 7, ErrorMessage = "Workout days per week must be between 1 and 7.")]
        public int WorkoutDaysPerWeek { get; set; }

        
    }
}
