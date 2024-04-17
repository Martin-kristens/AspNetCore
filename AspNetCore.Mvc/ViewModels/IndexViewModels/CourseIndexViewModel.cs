using Infrastrucutre.Models;

namespace AspNetCore.Mvc.ViewModels.IndexViewModels;

public class CourseIndexViewModel
{
    public IEnumerable<Category>? Categories { get; set; }
    public IEnumerable<Course>? Courses { get; set; }

}
