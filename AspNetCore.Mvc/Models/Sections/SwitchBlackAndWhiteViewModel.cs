using AspNetCore.Mvc.Models.Components;

namespace AspNetCore.Mvc.Models.Sections;

public class SwitchBlackAndWhiteViewModel
{
    public string? Id { get; set; }
    public string TitleLight { get; set; } = null!;
    public string TitleDark { get; set; } = null!;
    public ImageViewModel LaptopImg { get; set; } = new();
    public ImageViewModel CircleImg { get; set; } = new();
}
