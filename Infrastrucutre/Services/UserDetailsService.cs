using Infrastrucutre.Contexts;
using Infrastrucutre.Entities;
using Infrastrucutre.Factories;
using Infrastrucutre.Models;
using Infrastrucutre.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Security.Claims;

namespace Infrastrucutre.Services;

public class UserDetailsService(UserManager<UserEntity> userManager, UserRepository userRespository, DataContext context, IConfiguration configuration)
{
    private readonly UserManager<UserEntity> _userManager = userManager;
    private readonly UserRepository _userRespository = userRespository;
    private readonly DataContext _context = context;
    private readonly IConfiguration _configuration = configuration;

    #region UpdateUserAsync
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
    #endregion


    #region DeleteUserAsync
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
    #endregion


    #region UploadUserProfileImageAsync
    public async Task<bool> UploadUserProfileImageAsync(ClaimsPrincipal user, IFormFile file)
    {
        try
        {
            if (user != null && file != null && file.Length != 0)
            {
                var userEntity = await _userManager.GetUserAsync(user);
                if (userEntity != null)
                {
                    var fileName = $"p_{userEntity.Id}_{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), _configuration["FileUploadPath"]!, fileName);

                    using var fs = new FileStream(filePath, FileMode.Create);
                    await file.CopyToAsync(fs);

                    userEntity.ProfileImage = fileName;
                    _context.Update(userEntity);
                    await _context.SaveChangesAsync();

                    return true;
                }
            } 
        }
        catch (Exception ex)
        {

            Debug.WriteLine(ex.Message);
        }
        return false;
    }
    #endregion

}
