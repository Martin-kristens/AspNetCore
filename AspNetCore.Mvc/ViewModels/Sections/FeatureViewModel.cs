﻿using AspNetCore.Mvc.ViewModels.Components;

namespace AspNetCore.Mvc.Models.Sections;

public class FeatureViewModel
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string Text { get; set; } = null!;
    public List<FeatureBoxViewModel> FeatureBox { get; set; } = new();
}
