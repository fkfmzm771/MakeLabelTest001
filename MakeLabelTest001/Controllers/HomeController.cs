using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MakeLabelTest001.Models;
using Microsoft.Identity.Client;

namespace MakeLabelTest001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
      
            var clientId = "2244807b-abce-4703-8198-0323f7bc8b51";

            string[] scopes = new string[] { "name.read" };
            var app = PublicClientApplicationBuilder.Create(clientId).Build();
            Debug.WriteLine("--");
            Debug.WriteLine(app.AcquireTokenInteractive(scopes) + " test=========================== ");
            Debug.WriteLine("--");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
