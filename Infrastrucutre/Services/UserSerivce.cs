using Infrastrucutre.Entities;
using Infrastrucutre.Factories;
using Infrastrucutre.Models;
using Infrastrucutre.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Infrastrucutre.Services;

public class UserSerivce(AddressRepository addresRepository,UserManager<UserEntity> userManager,SignInManager<UserEntity> signInManager)
{
    private readonly UserManager<UserEntity> _userManager = userManager;
    private readonly SignInManager<UserEntity> _signInManager = signInManager;
    private readonly AddressRepository _addresRepository = addresRepository;

    public async Task<ResponseResult> CreateUserAsync(SignUpModel model)
    {
        try
        {
            var exists = await _userManager.Users.AnyAsync(x => x.Email == model.Email);
            if (exists)
            {
                return ResponseFactory.Exists();
            }

            var result = await _userManager.CreateAsync(UserFactory.Create(model));
            if (result.Succeeded)
            {
                return ResponseFactory.Ok("User was created successully");
            }
            else
            {
                return ResponseFactory.Error("Failed to create user");
            }
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }



    public async Task<ResponseResult> SignInUserAsync(SignInModel model)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return ResponseFactory.Ok("User logged in successfully");
                }
                else if (result.IsLockedOut)
                {
                    return ResponseFactory.Error("User account locked out");
                }
                else
                {
                    return ResponseFactory.Error("Incorrect email or password");
                }
            }
            else
            {
                return ResponseFactory.NotFound("User not found");
            }          
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }

    public async Task<ResponseResult> SignOutUserAsync(ClaimsPrincipal user)
    {
        try
        {
            
            if (_signInManager.IsSignedIn(user))
            {
                await _signInManager.SignOutAsync();
                return ResponseFactory.Ok("User signed out successfully");
            }
            else
            {
                return ResponseFactory.NotFound("No user is signed in right now");
            }

        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }
}

//create
//var exists = await _userManager.Users.AnyAsync(x => x.Email == model.Email);
//if (exists)
//{
//    return ResponseFactory.Exists("User with this email already exists");
//}
//else
//{
//    return UserFactory.Create();
//}

//singin
//var result = await _userRepository.GetOneAsync(x => x.Email == model.Email);
//if (result.StatusCode == StatusCode.OK && result.ContentResult != null)
//{
//    var userEntity = (UserEntity)result.ContentResult;

//    if (PasswordHasher.ValidateSecurePassword(model.Password, userEntity.Password, userEntity.SecurityKey))
//    {
//        return ResponseFactory.Ok();
//    }
//}

//return ResponseFactory.Error("Incorrect email or password");