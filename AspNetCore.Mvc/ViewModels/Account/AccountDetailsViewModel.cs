using Infrastrucutre.Entities;
using Infrastrucutre.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Mvc.ViewModels.Account;

public class AccountDetailsViewModel
{
    public ProfileInfoViewModel? ProfileInfo { get; set; }
    public UserEntity User { get; set; } = null!;
    public AccountDetailsBasicInfoModel? BasicInfo { get; set; } 
    public AccountDetailsAddressInfoModel? AddressInfo { get; set; } 
    
}
