using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Task Management Assistant You Gonna Love";
            return View();
        }
    }
}
