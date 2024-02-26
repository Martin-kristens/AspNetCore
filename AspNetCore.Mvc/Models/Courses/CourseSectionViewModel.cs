using AspNetCore.Mvc.Models.Components;
using AspNetCore.Mvc.Models.Courses.Components;

namespace AspNetCore.Mvc.Models.Courses;

public class CourseSectionViewModel
{
    public string Id { get; set; } = null!;
    public ProfileHeaderViewModel ProfileHeader { get; set; } = new ProfileHeaderViewModel();
    public NavMenuViewModel Nav { get; set; } = new();
    public CourseSearchViewModel CourseSearch { get; set; } = new();
    public List<CourseCardViewModel> CourseCard { get; set; } = new();
    public List<LinkViewModel> PageLinks { get; set; } = new();
    public ImageViewModel LeftArrow { get; set; } = new();
    public ImageViewModel RightArrow { get; set; } = new();

}
