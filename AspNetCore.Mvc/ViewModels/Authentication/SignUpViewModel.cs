using AspNetCore.Mvc.Models.Auth;

namespace AspNetCore.Mvc.ViewModels.Authentication;

public class SignUpViewModel
{
    public string Title { get; set; } = "hello";
    public SignUpModel Form { get; set; } = new SignUpModel();

    public bool TermAndConditions { get; set; } = true;
}
