using AspNetCore.Mvc.Dtos;
using AspNetCore.Mvc.Models.Sections;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace AspNetCore.Mvc.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Subscribe";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SubscriberDto dto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using var http = new HttpClient();

                    var url = "https://localhost:7263/api/subscribers";
                    var json = JsonConvert.SerializeObject(dto);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await http.PostAsync(url, data);

                    if (response.IsSuccessStatusCode)
                    {
                        TempData["Status"] = "Success";
                        return RedirectToAction("Index", "Home");

                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Conflict) 
                    {
                        TempData["Status"] = "AlreadyExists";
                        return RedirectToAction("Index", "Home");
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    //ModelState.AddModelError(string.Empty, "An error occurred while subscribing. Please try again later.");
                    TempData["Status"] = "ConnectionFailed";
                    return View(dto);
                }
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Terms()
        {
            ViewData["Title"] = "Terms";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacy";
            return View();
        }
    }
}
