using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Controllers;

public class SiteSettings : Controller
{
    //public IActionResult Index()
    //{
    //    return View();
    //}

    [HttpPost]
    public IActionResult CookieConsent()
    {
        var option = new CookieOptions
        {
            Expires = DateTime.Now.AddYears(1),
            HttpOnly = true,
            Secure = true
        };
        Response.Cookies.Append("CookieConsent", "true", option);
        return Ok();
    }
}
