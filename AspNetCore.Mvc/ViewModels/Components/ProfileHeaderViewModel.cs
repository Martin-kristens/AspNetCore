namespace AspNetCore.Mvc.ViewModels.Components;

public class ProfileHeaderViewModel
{
    public string? Id { get; set; }
    public LinkViewModel LogoLink { get; set; } = new LinkViewModel();
    public ImageViewModel Logo { get; set; } = new ImageViewModel();
    public List<LinkViewModel> Links { get; set; } = new List<LinkViewModel>();
    public string LightText { get; set; } = null!;
    public string DarkText { get; set; } = null!;
    public ImageViewModel Profile { get; set; } = new ImageViewModel();


}
