using AspNetCore.Mvc.ViewModels.Account;
using Infrastrucutre.Entities;
using Infrastrucutre.Factories;
using Infrastrucutre.Models;
using Infrastrucutre.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

[Authorize]
public class AccountController(SignInManager<UserEntity> signInManager, UserManager<UserEntity> userManager, UserDetailsService userDetailsService, AddressService addressService) : Controller
{
    private readonly SignInManager<UserEntity> _signInManager = signInManager;
    private readonly UserManager<UserEntity> _userManager = userManager;
    private readonly UserDetailsService _userDetailsService = userDetailsService;
    private readonly AddressService _addressService = addressService;


    #region Details

    [HttpGet]
    [Route("/account/details")]
    public async Task<IActionResult> Details()
    {
        if (!_signInManager.IsSignedIn(User))
        {
            return RedirectToAction("SignIn", "Auth");
        }

        var viewModel = new AccountDetailsViewModel
        {
            ProfileInfo = await PopulateProfileInfoAsync()
        };

        if (viewModel.BasicInfo == null)
        {
            viewModel.BasicInfo = await PopulateBasicInfoAsync();
        }

        if (viewModel.AddressInfo == null)
        {
            viewModel.AddressInfo = await PopulateAddressInfoAsync();
        }

        return View(viewModel);
    }
    #endregion


    #region [HttpPost] Details
    [HttpPost]
    [Route("/account/details")]
    public async Task<IActionResult> Details(AccountDetailsViewModel viewModel)
    {

        if (viewModel.BasicInfo != null)
        {
            if (viewModel.BasicInfo.FirstName != null && viewModel.BasicInfo.LastName != null && viewModel.BasicInfo.Email != null && viewModel.BasicInfo.Phone != null)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    user.FirstName = viewModel.BasicInfo.FirstName;
                    user.LastName = viewModel.BasicInfo.LastName;
                    user.Email = viewModel.BasicInfo.Email;
                    user.PhoneNumber = viewModel.BasicInfo.Phone;
                    user.Biography = viewModel.BasicInfo.Biography;

                    var result = await _userManager.UpdateAsync(user);
                    if (!result.Succeeded)
                    {
                        ModelState.AddModelError("IncorrectValues", "Something went wrong! Unable to save data");
                        ViewData["ErrorMessage"] = "Something went wrong! Unable to update basic info";
                    }
                }
            }
        }


        if (viewModel.AddressInfo != null)
        {
            var result = await _addressService.GetOrCreateAddressAsync(viewModel.AddressInfo, User);
            if (result.StatusCode == Infrastrucutre.Models.StatusCode.OK)
            {
                return RedirectToAction("Details");
            }

            return View(viewModel);
        }

        viewModel.ProfileInfo = await PopulateProfileInfoAsync();


        if (viewModel.BasicInfo == null)
        {
            viewModel.BasicInfo = await PopulateBasicInfoAsync();
        }

        if (viewModel.AddressInfo == null)
        {
            viewModel.AddressInfo = await PopulateAddressInfoAsync();
        }

        return View(viewModel);
    }
    #endregion


    #region PopulateProfileInfoAsync
    private async Task<ProfileInfoViewModel> PopulateProfileInfoAsync()
    {
        var user = await _userManager.GetUserAsync(User);

        return new ProfileInfoViewModel
        {
            FirstName = user!.FirstName,
            LastName = user.LastName,
            Email = user.Email!           
        };
    }
    #endregion


    #region PopulateBasicInfoAsync
    private async Task<AccountDetailsBasicInfoModel> PopulateBasicInfoAsync()
    {
        var user = await _userManager.GetUserAsync(User);

        return new AccountDetailsBasicInfoModel
        {
            UserId = user!.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email!,
            Phone = user.PhoneNumber!,
            Biography = user.Biography,
        };
    }
    #endregion


    #region PopulateAddressInfoAsync

    private async Task<AccountDetailsAddressInfoModel> PopulateAddressInfoAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user != null)
        {
            var address = await _addressService.GetAddressAsync(User);
            if (address != null)
            {
                return new AccountDetailsAddressInfoModel
                {
                    AddressLine_1 = address.StreetName_1 ?? "",
                    AddressLine_2 = address.StreetName_2 ?? "",
                    PostalCode = address.PostalCode ?? "",
                    City = address.City ?? ""
                };
            }
            else
            {
                return new AccountDetailsAddressInfoModel();
            }
          
        }
        

        return new AccountDetailsAddressInfoModel();
    }
    #endregion
}
