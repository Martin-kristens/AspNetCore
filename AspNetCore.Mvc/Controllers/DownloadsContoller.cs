using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers
{
    public class DownloadsContoller : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Downloads";
            return View();
        }

        public IActionResult AppleStore()
        {
            ViewData["Title"] = "App Store";
            return View();
        }

        public IActionResult GooglePlay()
        {
            ViewData["Title"] = "Google Plat";
            return View();
        }
    }
}
