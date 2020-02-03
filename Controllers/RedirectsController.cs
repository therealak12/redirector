using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;

namespace hw1.Controllers {
    [Route("{**page}")]
    public class RedirectsController : Controller {
        public IActionResult GoToUrl() {
            Console.WriteLine("received the request!");
            string url = Request.Path.ToString().Substring(1).Replace("/",".");
            Console.WriteLine(url);
            return Redirect("https://"+url);
        }
    }
}