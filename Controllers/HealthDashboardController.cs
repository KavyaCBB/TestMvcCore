using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestMvcCore.Models;

namespace TestMvcCore.Controllers
{
    public class HealthDashboardController : Controller
    {
        public LoginModel _loginModel;
        public IActionResult Index(LoginModel Model)
        {
            
            
            var model = JsonConvert.DeserializeObject<LoginModel>((string)TempData["LoginModel"]);
           if(model != null)
            {
                return View(model);
            }
            else
            {
                ModelState.AddModelError("key", "error");
            }

            return null;
        }

        

    }
}