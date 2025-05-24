using Microsoft.AspNetCore.Mvc;
using _367_project_repo_destroyersofevil.Models;

namespace _367_project_repo_destroyersofevil.Controllers
{
    public class AccountController : Controller
    {
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
                // Replace with real authentication
                if (model.Email == "test@example.com" && model.Password == "password")
                {
                    // Normally use Claims and SignInManager
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid login attempt.");
            }

            return View(model);
        }

        public IActionResult Logout()
        {
            // Dummy logout logic
            return RedirectToAction("Login");
        }
    }
}
