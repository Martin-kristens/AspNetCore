using AspNetCore.Mvc.Models.Components;
using AspNetCore.Mvc.Models.Courses.Components;

namespace AspNetCore.Mvc.Models.Courses;

public class WorkWithUsViewModel
{
    public string? Id { get; set; }
    public string? Text { get; set; }
    public HeadingViewModel Header { get; set; } = new HeadingViewModel();
    public LinkViewModel Link { get; set; } = new LinkViewModel();
    public ImageViewModel WorkImg { get; set; } = new ImageViewModel();
}
