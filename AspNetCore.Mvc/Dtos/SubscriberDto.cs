using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Mvc.Dtos;

public class SubscriberDto
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Email", Prompt = "Your Email")]
    [RegularExpression(@"^\w{2,}@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;
}
