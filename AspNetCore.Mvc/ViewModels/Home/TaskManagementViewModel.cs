using AspNetCore.Mvc.ViewModels.Components;

namespace AspNetCore.Mvc.ViewModels.Home;

public class TaskManagementViewModel
{
    public string? Id { get; set; }
    public ImageViewModel Dashboard { get; set; } = new();
    public string Title { get; set; } = null!;
    public List<TaskManagementBoxViewModel> TaskBox { get; set; } = new();
    public LinkViewModel Link { get; set; } = new();
}
