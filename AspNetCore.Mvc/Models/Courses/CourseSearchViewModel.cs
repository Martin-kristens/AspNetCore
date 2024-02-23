using AspNetCore.Mvc.Models.Components;

namespace AspNetCore.Mvc.Models.Courses;

public class CourseSearchViewModel
{
    public string Title { get; set; } = null!;
    public LinkViewModel ButtonText { get; set; } = new();
    public List<LinkViewModel> Items { get; set; } = new();
    public string Placeholder { get; set; } = null!;
}
