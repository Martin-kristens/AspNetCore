namespace AspNetCore.Mvc.ViewModels.Components;

public class FeatureBoxViewModel
{
    public ImageViewModel Image { get; set; } = null!;
    public string? Subheading { get; set; }
    public string? BoxText { get; set; }
}
