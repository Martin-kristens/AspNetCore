namespace Infrastrucutre.Models;

public class CourseResult
{
    public bool Succeeded { get; set; }
    public IEnumerable<Course>? Courses { get; set; }
}
