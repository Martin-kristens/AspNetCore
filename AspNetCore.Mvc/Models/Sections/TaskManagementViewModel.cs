using AspNetCore.Mvc.Models.Components;

namespace AspNetCore.Mvc.Models.Sections;

public class TaskManagementViewModel
{
    public string? Id { get; set; }
    public ImageViewModel Dashboard { get; set; } = new();
    public string Title { get; set; } = null!;
    public List<TaskManagementBoxViewModel> TaskBox { get; set; } = new();
    public LinkViewModel Link { get; set; } = new();
}
