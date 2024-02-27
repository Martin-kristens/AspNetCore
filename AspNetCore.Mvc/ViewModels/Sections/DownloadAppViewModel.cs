using AspNetCore.Mvc.ViewModels.Components;

namespace AspNetCore.Mvc.Models.Sections;

public class DownloadAppViewModel
{
    public string? Id { get; set; }
    public ImageViewModel MobileImg { get; set; } = new();
    public string Title { get; set; } = null!;
    public List<DownloadAppBoxViewModel> AppDownload { get; set; } = new();


}
