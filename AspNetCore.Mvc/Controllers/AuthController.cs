using AspNetCore.Mvc.ViewModels.Authentication;
using Infrastrucutre.Entities;
using Infrastrucutre.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

public class AuthController(UserSerivce userService, SignInManager<UserEntity> signInManager) : Controller
{
    private readonly UserSerivce _userService = userService;
    private readonly SignInManager<UserEntity> _signInManager = signInManager;

    #region [HttpGet]SignUp
    [HttpGet]
    [Route("/signup")]
    public IActionResult SignUp()
    {
        if (_signInManager.IsSignedIn(User))
        {
            return RedirectToAction("Details", "Account");
        }

        var viewModel = new SignUpViewModel();
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }
    #endregion


    #region [HttpPost]SignUp
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
            
        }
        viewModel.ErrorMessage = "User with same email already exists";
        return View(viewModel);
    }
    #endregion


    #region [HttpGet] SignIn
    [HttpGet]
    [Route("/signin")]
    public IActionResult SignIn(string returnUrl)
    {
        if (_signInManager.IsSignedIn(User))
        {
            return RedirectToAction("Details", "Account");
        }

        ViewData["ReturnUrl"] = returnUrl ?? Url.Content("~/");

        var viewModel = new SignInViewModel();
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }
    #endregion


    #region [HttpPost] SignIn
    [HttpPost]
    [Route("/signin")]
    public async Task<IActionResult> SignIn(SignInViewModel viewModel, string returnUrl)
    {

        if (ModelState.IsValid)
        {
            var result = await _userService.SignInUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastrucutre.Models.StatusCode.OK)
            {
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Details", "Account");
                }               
            }
        }

        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);
    }
    #endregion


    #region [HttpGet] SignOut

    [HttpGet]
    [Route("/signout")]
    public new async Task<IActionResult> SignOut()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("SignIn", "Auth");
    }
    #endregion
}

