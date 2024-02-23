using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Subscribe";
            return View();
        }

        public IActionResult Terms()
        {
            ViewData["Title"] = "Terms";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacy";
            return View();
        }
    }
}
