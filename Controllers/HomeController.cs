using Microsoft.AspNetCore.Mvc;
using _367_project_repo_destroyersofevil.Models;

namespace _367_project_repo_destroyersofevil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new LoginViewModel());
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
