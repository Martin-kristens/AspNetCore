using Infrastrucutre.Entities;
using Infrastrucutre.Factories;
using Infrastrucutre.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastrucutre.Services;

public class UserDetailsService(UserManager<UserEntity> userManager)
{
    private readonly UserManager<UserEntity> _userManager = userManager;

    //public async Task<ResponseResult> GetUserAsync(AccountDetailsBasicInfoModel basicInfoModel)
    //{
    //    try
    //    {
    //        var user = await _userManager.FindByEmailAsync(basicInfoModel.Email);
    //        if (user != null)
    //        {
    //            user.FirstName = basicInfoModel.FirstName;
    //            user.LastName = basicInfoModel.LastName;
    //            user.Email = basicInfoModel.Email;
    //            user.PhoneNumber = basicInfoModel.Phone;
    //            user.Biography = basicInfoModel.Biography;           
    //        }
    //        else
    //        {
    //            return ResponseFactory.NotFound("User not found");
    //        }
    //    }
    //    catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    //    return null!;
    //}

    public async Task<ResponseResult> UpdateUserAsync(AccountDetailsBasicInfoModel basicInfoModel)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(basicInfoModel.Email);
            if (user != null)
            {
                
                user.FirstName = basicInfoModel.FirstName;
                user.LastName = basicInfoModel.LastName;
                user.Email = basicInfoModel.Email;
                user.PhoneNumber = basicInfoModel.Phone;
                user.Biography = basicInfoModel.Biography;

                var updateUserResult = await _userManager.UpdateAsync(user);
                if (updateUserResult.Succeeded) 
                {
                    return ResponseFactory.Ok(updateUserResult);
                }
                else
                {
                    return ResponseFactory.Error("Failed to update the user information");
                }
            }
            else
            {
                return ResponseFactory.NotFound("User not found");
            }
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }

    public async Task<ResponseResult> DeleteUserAsync(UserEntity userEntity)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(userEntity.Email!);
            if (user != null) 
            {
                var deletedUserResult = await _userManager.DeleteAsync(user);
                return ResponseFactory.Ok(deletedUserResult);
            }
            else
            {
                return ResponseFactory.NotFound();
            }
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }

    
}
