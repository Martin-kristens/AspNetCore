﻿namespace AspNetCore.Mvc.ViewModels.Account;

public class ProfileInfoViewModel
{
    public string FirstName { get; set; } = null!;


    public string LastName { get; set; } = null!;


    public string Email { get; set; } = null!;
    public string ProfileImageUrl { get; set; } = "account-profile.svg";
}