using Infrastrucutre.Entities;
using Infrastrucutre.Models;

namespace AspNetCore.Mvc.ViewModels.Account;

public class AccountDetailsViewModel
{
    //public string Title { get; set; } = null!;
    public UserEntity User { get; set; } = null!;
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel();
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
    
}
