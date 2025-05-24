using System.ComponentModel.DataAnnotations;

namespace _367_project_repo_destroyersofevil.Models
{
    public class LoginViewModel
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

