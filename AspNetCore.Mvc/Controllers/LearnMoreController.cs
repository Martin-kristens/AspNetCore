using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers
{
    public class LearnMoreController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Learn More";
            return View();
        }
    }
}
