using Infrastrucutre.Models;

namespace AspNetCore.Mvc.ViewModels.Authentication;

public class SignUpViewModel
{
    public string Title { get; set; } = "Sign Up";
    public SignUpModel Form { get; set; } = new SignUpModel();

    public bool TermAndConditions { get; set; } = true;
}
