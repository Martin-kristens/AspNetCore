﻿using AspNetCore.Mvc.Models.Components;

namespace AspNetCore.Mvc.Models.Courses;

public class CourseCardViewModel
{
    public ImageViewModel CardImg { get; set; } = new();
    public LinkViewModel Link { get; set; } = new();
    public ImageViewModel ImageIcon { get; set; } = new();
    public string CardHeader { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string PriceText { get; set; } = null!;
    public string? PriceSale { get; set; } 
    public ImageViewModel ClockIcon { get; set; } = new();
    public string HoursText { get; set; } = null!;
    public ImageViewModel ThumbIcon { get; set; } = null!;
    public string RatingText { get; set; } = null!;

}
