using AspNetCore.Mvc.ViewModels.Components;

namespace AspNetCore.Mvc.ViewModels.Courses.Components;

public class NavMenuViewModel
{
    public LinkViewModel IndexImg { get; set; } = new();
    public ImageViewModel HouseIcon { get; set; } = new();
    public LinkViewModel HomeLink { get; set; } = new();
    public ImageViewModel Vector { get; set; } = new();
    public LinkViewModel CoursesLink { get; set; } = new();
}
