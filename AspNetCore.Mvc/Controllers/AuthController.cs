using AspNetCore.Mvc.ViewModels.Authentication;
using Infrastrucutre.Entities;
using Infrastrucutre.Models;
using Infrastrucutre.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

public class AuthController(UserSerivce userService, SignInManager<UserEntity> signInManager) : Controller
{
    private readonly UserSerivce _userService = userService;
    private readonly SignInManager<UserEntity> _signInManager = signInManager;


    [HttpGet]
    [Route("/signup")]
    public IActionResult SignUp()
    {
        //if (_signInManager.IsSignedIn(User))
        //{
        //    return RedirectToAction("Details", "Account");
        //}

        var viewModel = new SignUpViewModel();
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [HttpPost]
    [Route("/signup")]
    public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.CreateUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastrucutre.Models.StatusCode.OK)
            {
                return RedirectToAction("SignIn", "Auth");
            }
            else
            {
                viewModel.ErrorMessage = "User with same email already exists";
            }
        }
        return View(viewModel);
    }

    [HttpGet]
    [Route("/signin")]
    public IActionResult SignIn()
    {
        //if (_signInManager.IsSignedIn(User))
        //{
        //    return RedirectToAction("Details", "Account");
        //}
        var viewModel = new SignInViewModel();
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [HttpPost]
    [Route("/signin")]
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

        //ModelState.AddModelError("IncorrectValues", "Incorrect email or password");
        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);
    }

    [HttpGet]
    [Route("/signout")]
    public new async Task<IActionResult> SignOut()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("SignIn", "Auth");
    }
}

