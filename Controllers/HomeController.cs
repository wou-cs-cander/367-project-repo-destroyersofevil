using Microsoft.AspNetCore.Mvc;

namespace WorkoutGeneratorApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
