using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using System.Web;

namespace hw1.Controllers {
    [Route("{**page}")]
    public class RedirectsController : Controller {
        public IActionResult GoToUrl() {
            Console.WriteLine("received the request!");
            string url = Request.Path.ToString().Substring(1).Replace("/",".");
            Console.WriteLine(url);
            HttpContext.Response.StatusCode = 302;
            return Redirect("https://"+url);
        }
    }
}