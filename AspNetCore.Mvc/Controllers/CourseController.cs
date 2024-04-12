
using AspNetCore.Mvc.ViewModels.IndexViewModels;
using Infrastrucutre.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

public class CourseController(CategoryService category, CourseService course) : Controller
{
    private readonly CategoryService _category = category;
    private readonly CourseService _course = course;

    public async Task<IActionResult> Index(string category = "all")
    {
        var viewModel = new CourseIndexViewModel
        {
            Categories = await _category.GetCategoriesAsync(),
            Courses = await _course.GetCoursesAsync(category)
        };



        ViewData["Title"] = "Courses";

        return View(viewModel);
    }
}
