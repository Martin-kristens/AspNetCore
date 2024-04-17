using AspNetCore.Mvc.Dtos;
using AspNetCore.Mvc.ViewModels.Authentication;
using AspNetCore.Mvc.ViewModels.Components;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Mvc.Models.Sections;

public class SubscribeViewModel
{
    [Required]
    [Display(Name = "Email", Prompt = "Your Email")]
    public SubscriberDto Subscriber { get; set; } = new();  
}
