
using AspNetCore.Mvc.ViewModels.IndexViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new CourseIndexViewModel();
        ViewData["Title"] = "Courses";

        return View(viewModel);
    }
}
