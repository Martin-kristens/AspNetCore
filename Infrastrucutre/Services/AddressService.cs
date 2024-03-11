using Infrastrucutre.Entities;
using Infrastrucutre.Factories;
using Infrastrucutre.Models;
using Infrastrucutre.Repositories;
using System.Linq.Expressions;

namespace Infrastrucutre.Services;

public class AddressService(AddressRepository addressRepository)
{
    private readonly AddressRepository _addressRepository = addressRepository;

    public async Task<ResponseResult> GetOrCreateAddressAsync(string streetName_1, string streetName_2, string postalCode, string city)
    {
        try
        {
            var result = await GetAddressAsync(streetName_1, streetName_2, postalCode, city);
            if (result.StatusCode == StatusCode.NOT_FOUND)
            {
                result = await CreateAddressAsync(streetName_1, streetName_2, postalCode, city);
            }

            return result;
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }

    public async Task<ResponseResult> CreateAddressAsync(string streetName_1, string streetName_2, string postalCode, string city)
    {
		try
		{
            var exists = await _addressRepository.AlreadyExistsAsync(x => x.StreetName_1 == streetName_1 && x.PostalCode == postalCode && x.City == city);
            if (exists == null) 
            {
                var result = await _addressRepository.CreateOneAsync(AddressFactory.Create(streetName_1, streetName_2, postalCode, city));
                if (result.StatusCode == StatusCode.OK)
                {
                    return ResponseFactory.Ok(AddressFactory.Create((AddressEntity)result.ContentResult!));
                }

                return result;               
            }

            return exists;

		}
		catch (Exception ex) {return ResponseFactory.Error(ex.Message);}
    }

    public async Task<ResponseResult> GetAddressAsync(string streetName_1, string streetName_2, string postalCode, string city)
    {
        try
        {
            var result = await _addressRepository.GetOneAsync(x => x.StreetName_1 == streetName_1 && x.PostalCode == postalCode && x.City == city);
            return result;
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }

    public async Task<ResponseResult> UpdateAddressAsync(string streetName_1, string streetName_2, string postalCode, string city)
    {
        try
        {
            Expression<Func<AddressEntity, bool>> predicate = address => address.StreetName_1 == streetName_1 && 
                                                                address.PostalCode == postalCode && address.City == city;

            var result = await _addressRepository.GetOneAsync(predicate);
            if (result.StatusCode == StatusCode.OK && result.ContentResult != null)
            {
                var updateAddress = new AddressEntity
                {
                   StreetName_1 = streetName_1,
                    StreetName_2 = streetName_2,
                    PostalCode = postalCode,
                   City = city
                };

                var updateAddressResult = _addressRepository.UpdateOneAsync(predicate, updateAddress);
                return ResponseFactory.Ok(updateAddressResult);
            }

            return ResponseFactory.NotFound("No address was found");
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }

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
}
