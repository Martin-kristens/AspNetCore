using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Mvc.Models.Auth;

public class SignUpModel
{
    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "Invalid first name")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Invalid last name")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Email address", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [Display(Name = "password", Prompt = "Enter your password", Order = 3)]
    [DataType(DataType.Password)]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Invalid password")]
    public string Password { get; set; } = null!;

    [Display(Name = "confirmpassword", Prompt = "Confirm your password", Order = 4)]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Password does not match")]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "I agree to the terms and conditions.", Order = 5)]
    [Required(ErrorMessage = "Invalid last name")]
    public bool TermsAndConditions { get; set; } = false!;

}
