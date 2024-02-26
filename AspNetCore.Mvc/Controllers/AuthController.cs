using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SignIn()
        {
            ViewData["Title"] = "Sign Ip";
            return View();
        }

        public IActionResult SignUn()
        {
            ViewData["Title"] = "Sign Up";
            return View();
        }

        public new IActionResult SignOut()
        {
            //när man sign out kommer man automatiskt till HomeControllern 
            return RedirectToAction("Index", "Home");
        }
    }
}
