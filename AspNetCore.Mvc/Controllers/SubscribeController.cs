using AspNetCore.Mvc.Dtos;
using AspNetCore.Mvc.Models.Sections;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;

namespace AspNetCore.Mvc.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Subscribe";
            var subscriberDto = new SubscriberDto();
            return View();
            //return RedirectToAction("Index", "Home");
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
                        //viewModel.IsSubscribed = true;
                        ViewData["SuccessMessage"] = "Subscription successful!";
                        return RedirectToAction("Index", "Home");

                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    ModelState.AddModelError(string.Empty, "An error occurred while subscribing. Please try again later.");
                    return View(dto);
                }
                //return RedirectToAction("Index");
            }

            return BadRequest(ModelState);
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
