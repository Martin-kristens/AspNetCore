using AspNetCore.Mvc.ViewModels.Components;

namespace AspNetCore.Mvc.Models.Sections;

public class IntegrateToolViewModel
{
    public string? Id { get; set; }
    public string Title { get; set; } = null!;
    public string Text { get; set; } = null!;
    public List<ToolBoxViewModel> ToolBox { get; set; } = new();
}
