using AspNetCore.Mvc.Models.Accounts;

namespace AspNetCore.Mvc.ViewModels.Account;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        ProfileImage = "images/account-profile.svg",
        FirstName = "Martin",
        LastName = "Kristensen",
        Email = "nisse@mail.se"
    };
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
    
}
