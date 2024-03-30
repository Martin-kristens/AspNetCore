using Infrastrucutre.Entities;
using Infrastrucutre.Helpers;
using Infrastrucutre.Models;

namespace Infrastrucutre.Factories;

public class UserFactory
{

    public static UserEntity Create(SignUpModel model)
    {
        try
        {
            var date = DateTime.Now;

            return new UserEntity 
            { 
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email
            };
        }
        catch { }
        return null!;
    }
}