using AspNetCore.Mvc.ViewModels.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

public class AuthController : Controller
{
    //tar bort auth i sökrutan
    [Route("/signup")]
    [HttpGet]
   public IActionResult SignUp()
    {

        var viewModel = new SignUpViewModel();
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }
        return RedirectToAction("SignIn", "Auth");
        
    }
}

