using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Mvc.ViewModels.Account;

public class AccountDetailsBasicInfoViewModel
{
    public string UserId { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Biography { get; set; }
}
