namespace _367_project_repo_destroyersofevil.Models
{
    public class WorkoutSession
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Exercise> Exercises { get; set; } = new();
        public string Notes { get; set; } = string.Empty;
        public bool Completed { get; set; }
    }
}
