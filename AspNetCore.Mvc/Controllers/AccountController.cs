using AspNetCore.Mvc.ViewModels.Account;
using Infrastrucutre.Entities;
using Infrastrucutre.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

[Authorize]
public class AccountController : Controller
{
    private readonly SignInManager<UserEntity> _signInManager;
    private readonly UserManager<UserEntity> _userManager;
    private readonly UserDetailsService _userDetailsService;

    public AccountController(SignInManager<UserEntity> signInManager, UserManager<UserEntity> userManager, UserDetailsService userDetailsService)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _userDetailsService = userDetailsService;
    }

    [HttpGet]
    [Route("/account/details")]
    public async Task<IActionResult> Details()
    {
        if (!_signInManager.IsSignedIn(User))
        {
            return RedirectToAction("SignIn", "Auth");
        }

        var userEntity = await _userManager.GetUserAsync(User);

        var viewModel = new AccountDetailsViewModel()
        {
            User = userEntity!
        };

        return View(viewModel);
    }

    [HttpGet]
    [Route("/account/details/basicinfo")]
    public async Task<IActionResult> BasicInfo()
    {
        if (!_signInManager.IsSignedIn(User))
        {
            return RedirectToAction("SignIn", "Auth");
        }

        var userEntity = await _userManager.GetUserAsync(User);

        var viewModel = new AccountDetailsViewModel()
        {
            User = userEntity!
        };

        return View(viewModel);
    }

    [HttpPost]
    [Route("/account/details/basicInfo")]
    public async Task<IActionResult> BasicInfo(AccountDetailsViewModel viewModel)
    {
        var result = await _userManager.UpdateAsync(viewModel.User);
        if (!result.Succeeded)
        {
            ModelState.AddModelError("Failed to save data", "Unable to save the data");
            ViewData["ErrorMessage"] = "Unable to save the data";
        }
        return RedirectToAction("Details", "Account", viewModel);
    }
}
