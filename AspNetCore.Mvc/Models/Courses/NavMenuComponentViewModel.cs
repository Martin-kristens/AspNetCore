using AspNetCore.Mvc.Models.Components;

namespace AspNetCore.Mvc.Models.Courses;

public class NavMenuViewModel
{
    public LinkViewModel IndexImg { get; set; } = new();
    public ImageViewModel HouseIcon { get; set; } = new();
    public LinkViewModel HomeLink { get; set; } = new();
    public ImageViewModel Vector { get; set; } = new();
    public LinkViewModel CoursesLink { get; set; } = new();
}
