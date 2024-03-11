using AspNetCore.Mvc.ViewModels.Account;
using Infrastrucutre.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<UserEntity> _userManager;
    private readonly SignInManager<UserEntity> _signInManager;

    public AccountController(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    //private readonly AccountService _accountService;

    //public AccountController(AccountService accountService)
    //{
    //    _accountService = accountService;
    //}

    [HttpGet]
    [Route("/account/details")]
    public IActionResult Details()
    {
        if (!_signInManager.IsSignedIn(User))
        {
            return RedirectToAction("SignIn", "Auth");
        }

        return View();
    }

    //[HttpGet]
    //[Route("/account")]
    //public IActionResult Details()
    //{
    //    var viewModel = new AccountDetailsViewModel();
    //    //viewModel.BasicInfo = _accountService.GetBasicInfo();
    //    //viewModel.AddressInfo = _accountService.GetAddressInfo();

    //    return View(viewModel);
    //}

    [HttpPost]
    public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
    {
        //_accountService.SaveBasicInfo(viewModel.BasicInfo);

        return RedirectToAction(nameof(Details));
    }

    [HttpPost]
    public IActionResult AddressInfo(AccountDetailsViewModel viewModel)
    {
        //_accountService.SaveAddressInfo(viewModel.AddressInfo);
        return RedirectToAction(nameof(Details));
    }
}
