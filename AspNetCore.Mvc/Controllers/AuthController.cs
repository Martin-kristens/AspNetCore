using AspNetCore.Mvc.ViewModels.Authentication;
using Infrastrucutre.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

public class AuthController(UserSerivce userService) : Controller
{
    private readonly UserSerivce _userService = userService;

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
    public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.CreateUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastrucutre.Models.StatusCode.OK)
            {
                return RedirectToAction("SignIn", "Auth");
            }           
        }
        return View(viewModel);       
    }

    [Route("/signin")]
    [HttpGet]
    public IActionResult SignIn()
    {

        var viewModel = new SignInViewModel();
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [Route("/signin")]
    [HttpPost]
    public async Task<IActionResult> SignIn(SignInViewModel viewModel)
    {
        
        if (ModelState.IsValid)
        {
            var result = await _userService.SignInUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastrucutre.Models.StatusCode.OK)
            {
                return RedirectToAction("Details", "Account");
            }             
        }

        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);
    }
}

