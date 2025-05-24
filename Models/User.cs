using System.ComponentModel.DataAnnotations;

namespace _367_project_repo_destroyersofevil.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}

