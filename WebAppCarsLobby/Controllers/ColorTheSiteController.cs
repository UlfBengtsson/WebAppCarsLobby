using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCarsLobby.Controllers
{

    public class ColorTheSiteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string cookieColor = Request.Cookies["cookieColor"];

            if (cookieColor != null)
            {
                ViewBag.CookieColor = cookieColor;
            }

            return View();
        }

        [HttpPost]
        public IActionResult SetColor(int id)
        {
            //Add cookie to Response object
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(1);

            switch (id)
            {
                case 1:
                    Response.Cookies.Append("cookieColor", "blackPage", option);
                    break;
                case 2:
                    Response.Cookies.Append("cookieColor", "whitePage", option);
                    break;
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
