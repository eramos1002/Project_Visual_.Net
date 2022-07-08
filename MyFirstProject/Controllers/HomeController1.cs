using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
