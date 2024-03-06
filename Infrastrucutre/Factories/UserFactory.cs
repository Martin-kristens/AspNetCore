using Infrastrucutre.Entities;
using Infrastrucutre.Helpers;
using Infrastrucutre.Models;

namespace Infrastrucutre.Factories;

public class UserFactory
{
    public static UserEntity Create()
    {
        try
        {
            var date = DateTime.Now;

            return new UserEntity() 
            {
                Id = Guid.NewGuid().ToString(),
                Created = date,
                Modified = date
            };
        }
        catch { }
        return null!;
    }

    public static UserEntity Create(SignUpModel model)
    {
        try
        {
            var date = DateTime.Now;

            return new UserEntity 
            { 
                Id = Guid.NewGuid().ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Created = date,
                Modified = date
            };
        }
        catch { }
        return null!;
    }
}
//var (password, securityKey) = PasswordHasher.GenerateSecurePassword(model.Password);
//Password = password,
//SecurityKey = securityKey,