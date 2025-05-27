namespace _367_project_repo_destroyersofevil.Models
{
    public class WorkoutLogEntry
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime SessionDate { get; set; }
        public string Feedback { get; set; } = string.Empty;
        public int EffortLevel { get; set; }  // Scale of 1–10
    }
}
