namespace AspNetCore.Mvc.ViewModels.Components;

public class TermsAndPrivacyViewModel
{
    public string Text1 { get; set; } = null!;
    public LinkViewModel Link1 { get; set; } = new();
    public LinkViewModel Link2 { get; set; } = new();
    public string Text2 { get; set; } = null!;
    public string Text3 { get; set; } = null!;
}
