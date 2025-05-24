namespace _367_project_repo_destroyersofevil.Models
{
    public class Exercise
    {
        public int Id { get; set; }               // Unique identifier for the exercise
        public string Name { get; set; }          // Name of the exercise
        public string Description { get; set; }   // Description or instructions
        public string MuscleGroup { get; set; }   // Target muscle group
        public string Equipment { get; set; }     // Equipment needed (if any)
        public string Difficulty { get; set; }    // Difficulty level (e.g., easy, medium, hard)

        // You can add more fields matching your API response structure
    }
}
