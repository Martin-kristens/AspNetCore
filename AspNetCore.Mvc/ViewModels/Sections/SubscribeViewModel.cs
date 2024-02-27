using AspNetCore.Mvc.ViewModels.Components;

namespace AspNetCore.Mvc.Models.Sections;

public class SubscribeViewModel
{
    public string? Id { get; set; }
    public string Title { get; set; } = null!;
    public ImageViewModel HeadingImg { get; set; } = new();
    public string Subheading { get; set; } = null!;
    public List<SignUpBoxViewModel> SignUpBox { get; set; } = new();
    public string PlaceholderText { get; set; } = null!;
    public LinkViewModel Link { get; set; } = new();
    public TermsAndPrivacyViewModel TermsAndPrivacy { get; set; } = null!;
}
