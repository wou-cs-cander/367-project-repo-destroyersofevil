namespace _367_project_repo_destroyersofevil.Models
{
    public class WorkoutPlan
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInWeeks { get; set; }
        public List<WorkoutSession> Sessions { get; set; } = new();
    }
}
