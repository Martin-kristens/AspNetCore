using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

public class AuthController : Controller
{
    //tar bort auth i sökrutan
    [Route("/signup")]
   public IActionResult SignUp()
    {
        return View();
    }
}
