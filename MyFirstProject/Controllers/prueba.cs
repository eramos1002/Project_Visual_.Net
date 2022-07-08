using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    public class prueba : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
