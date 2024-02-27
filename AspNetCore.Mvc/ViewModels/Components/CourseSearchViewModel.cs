namespace AspNetCore.Mvc.ViewModels.Components;

public class CourseSearchViewModel
{
    public string Title { get; set; } = null!;
    public LinkViewModel ButtonText { get; set; } = new();
    public List<LinkViewModel> Items { get; set; } = new();
    public string Placeholder { get; set; } = null!;
}
