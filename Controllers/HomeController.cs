using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestMvcCore.Models;

namespace TestMvcCore.Controllers
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
            return View();
        }

        [Route("/Home/About/")]
        public IActionResult AboutUs()
        {
            return View("About");
        }

        [Route("/Home/Contact/")]
        public IActionResult ContactUs()
        {
            return View("Contact");
        }
    }
}
