using Infrastrucutre.Models;

namespace AspNetCore.Mvc.ViewModels.Authentication;

public class SignInViewModel
{
    public string Title { get; set; } = "Sign In";
    public SignInModel Form { get; set; } = new SignInModel();
    public string? ErrorMessage { get; set; }
}
