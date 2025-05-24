using System.ComponentModel.DataAnnotations;

namespace _367_project_repo_destroyersofevil.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }   // <-- must be here

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }  // <-- must be here
    }
}



