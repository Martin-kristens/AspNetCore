
using AspNetCore.Mvc.ViewModels.IndexViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel(); 
           
            ViewData["Title"] = viewModel.Title;

            return View(viewModel);
        }
    }
}
