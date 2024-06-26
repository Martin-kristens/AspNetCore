﻿using Infrastrucutre.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Infrastrucutre.Models;

public class SignUpModel
{
    [DataType(DataType.Text)]
    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name is required")]
    [MinLength(2, ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;


    [DataType(DataType.Text)]
    [Display(Name = "Last name", Prompt = "Last name is required", Order = 1)]
    [Required(ErrorMessage = "Last name is required")]
    [MinLength(2, ErrorMessage = "First name is required")]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email address", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Your email address is invalid")]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter your password", Order = 3)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Invalid password must be a strong password")]
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm Password", Prompt = "Confirm your password", Order = 4)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Fields does not match")]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "I agree to the terms and conditions.", Order = 5)]
    [CheckBoxRequired(ErrorMessage = " You must accept the terms and conditions to proceed.")]
    public bool TermsAndConditions { get; set; } = false!;
}
