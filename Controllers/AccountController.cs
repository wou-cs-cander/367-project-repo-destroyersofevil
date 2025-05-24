using Microsoft.AspNetCore.Mvc;
using System.Linq;  // For LINQ queries
using System.Threading.Tasks; // For async/await
using _367_project_repo_destroyersofevil.Models;
using _367_project_repo_destroyersofevil.Data;




namespace _367_project_repo_destroyersofevil.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Simple user lookup in database (replace with hashed passwords etc.)
                var user = _context.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    // TODO: Set authentication cookie/session here

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid login attempt.");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Check if user with email already exists
                if (_context.Users.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use.");
                    return View(model);
                }

                // Create new User entity
                var user = new User
                {
                    Email = model.Email,
                    Password = model.Password // NOTE: In production, hash passwords! Never store plain text
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                // After registration, redirect to login page
                return RedirectToAction("Login");
            }

            return View(model);
        }

        public IActionResult Logout()
        {
            // TODO: Clear authentication cookie/session

            return RedirectToAction("Login");
        }
    }
}
