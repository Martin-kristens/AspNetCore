﻿namespace AspNetCore.Mvc.ViewModels.Components;

public class ToolBoxViewModel
{
    public ImageViewModel Image { get; set; } = new();
    public string BoxText { get; set; } = null!;
}
