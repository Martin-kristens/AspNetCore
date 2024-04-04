using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Mvc.Dtos;

public class SubscriberDto
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Email", Prompt = "Your Email")]
    public string Email { get; set; } = null!;
}
