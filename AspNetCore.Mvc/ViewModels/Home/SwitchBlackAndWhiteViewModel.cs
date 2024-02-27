using AspNetCore.Mvc.ViewModels.Components;

namespace AspNetCore.Mvc.ViewModels.Home;

public class SwitchBlackAndWhiteViewModel
{
    public string? Id { get; set; }
    public string TitleLight { get; set; } = null!;
    public string TitleDark { get; set; } = null!;
    public ImageViewModel LaptopImg { get; set; } = new();
    public ImageViewModel CircleImg { get; set; } = new();
}
