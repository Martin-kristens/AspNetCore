namespace AspNetCore.Mvc.ViewModels.Components;

public class DownloadAppBoxViewModel
{
    public string AppStore { get; set; } = null!;
    public List<ImageViewModel> RatingImg { get; set; } = new();
    public string Subheading { get; set; } = null!;
    public string Ratings { get; set; } = null!;
    public LinkViewModel Link { get; set; } = null!;
    public ImageViewModel LinkImages { get; set; } = null!;

}
