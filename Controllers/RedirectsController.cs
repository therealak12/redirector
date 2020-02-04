using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using System.Web;

namespace hw1.Controllers
{
    [Route("{**page}")]
    public class RedirectsController : Controller
    {
        public IActionResult GoToUrl()
        {
            Console.WriteLine("received the request!");
            string url = Request.Path.ToString().Substring(1).Replace("/", ".");
            Console.WriteLine(url);
            return Redirect("https://" + url);
            // using (var client = new MyClient())
            // {
            //     try
            //     {
            //         client.HeadOnly = true;
            //         string s2 = client.DownloadString("https://" + url);
            //         return Redirect("https://" + url);
            //     }
            //     catch (Exception exception)
            //     {
            //         Console.WriteLine(exception);
            //         return NotFound("404 not found");
            //     }
            // }
        }
    }

    // class MyClient : WebClient
    // {
    //     public bool HeadOnly { get; set; }
    //     protected override WebRequest GetWebRequest(Uri address)
    //     {
    //         WebRequest req = base.GetWebRequest(address);
    //         if (HeadOnly && req.Method == "GET")
    //         {
    //             req.Method = "HEAD";
    //         }
    //         return req;
    //     }
    // }
}