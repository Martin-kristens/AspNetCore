using Infrastrucutre.Contexts;
using Infrastrucutre.Entities;
using Infrastrucutre.Factories;
using Infrastrucutre.Models;
using Infrastrucutre.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Claims;

namespace Infrastrucutre.Services;

public class AddressService(AddressRepository addressRepository, DataContext context, UserManager<UserEntity> userManager)
{
    private readonly AddressRepository _addressRepository = addressRepository;
    private readonly DataContext _context = context;
    private readonly UserManager<UserEntity> _userManager = userManager;

    #region GetAddressAsync
    public async Task<AddressEntity> GetAddressAsync(ClaimsPrincipal User)
    {
        try
        {
            var userEntity = await _userManager.GetUserAsync(User);
            if (userEntity != null)
            {
                var addressEntity = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == userEntity.AddressId);
                return addressEntity!;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;    
    }
    #endregion


    #region CreateAddressAsync
    public async Task<int> CreateAddressAsync(AddressEntity entity)
    {
       try
        {
            var newAddress = _context.Addresses.Add(entity);
            var result = await _context.SaveChangesAsync();
            if (result == 1)
            {
                return newAddress.Entity.Id;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return 0;
    }
    #endregion


    #region UpdateAddressAsync
    public async Task<bool> UpdateAddressAsync(AddressEntity entity, ClaimsPrincipal user)
    {
        try
        {
            var userEntity = await _userManager.GetUserAsync(user);

            var existing = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == userEntity!.AddressId);
            if (existing != null)
            {
                _context.Entry(entity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
                return true;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return false;
    }
    #endregion


    #region GetOrCreateAddressAsync
    public async Task<ResponseResult> GetOrCreateAddressAsync(AccountDetailsAddressInfoModel addressInfoModel, ClaimsPrincipal user)
    {
        try
        {
            var userEntity = await _userManager.GetUserAsync(user);
            var existingAddress = await _context.Addresses.FirstOrDefaultAsync(x => x.StreetName_1 == addressInfoModel.AddressLine_1 && x.StreetName_2 == addressInfoModel.AddressLine_2 && x.PostalCode == addressInfoModel.PostalCode && x.City == addressInfoModel.City);
            if (existingAddress != null && userEntity != null)
            {
                userEntity.AddressId = existingAddress.Id;

                var saveUser = await _userManager.UpdateAsync(userEntity);
                if (saveUser.Succeeded)
                {
                    return ResponseFactory.Ok(saveUser);
                }             
            }
            else
            {
                if (addressInfoModel != null && userEntity != null)
                {
                    var addressEntity = new AddressEntity()
                    {
                        StreetName_1 = addressInfoModel.AddressLine_1,
                        StreetName_2 = addressInfoModel?.AddressLine_2,
                        PostalCode = addressInfoModel!.PostalCode,
                        City = addressInfoModel.City
                    };

                    var newAddress = await _context.Addresses.AddAsync(addressEntity);
                    
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        userEntity.AddressId = newAddress.Entity.Id;

                        var saveUser = await _userManager.UpdateAsync(userEntity);
                        if (saveUser.Succeeded)
                        {
                            return ResponseFactory.Ok(saveUser);
                        }
                    }
                }              
            }

            return ResponseFactory.Error();
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }
    #endregion


    #region DeleteAddressAsync
    public async Task<ResponseResult> DeleteAddressAsync(string streetName_1, string streetName_2, string postalCode, string city)
    {
        try
        {
            Expression<Func<AddressEntity, bool>> predicate = address => address.StreetName_1 == streetName_1 &&
                                                               address.PostalCode == postalCode && address.City == city;

            var findAddress = await _addressRepository.GetOneAsync(predicate);
            if (findAddress.StatusCode == StatusCode.OK && findAddress.ContentResult != null)
            {
                var deleteAddress = await _addressRepository.DeleteOneAsync(predicate);
                return ResponseFactory.Ok("Address was successfully deleted");
            }
            else
            {
                return ResponseFactory.NotFound("No address was found");
            }
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }
    #endregion
}
