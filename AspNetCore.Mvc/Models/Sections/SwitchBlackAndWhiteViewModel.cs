using AspNetCore.Mvc.Models.Components;

namespace AspNetCore.Mvc.Models.Sections;

public class SwitchBlackAndWhiteViewModel
{
    public string? Id { get; set; }
    public string Title { get; set; } = null!;
    public List<ImageViewModel> Image { get; set; } = new();
}
