using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SignUp()
        {
            ViewData["Title"] = "Sign Up";
            return View();
        }
    }
}
