using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestMvcCore.Models;

namespace TestMvcCore.Controllers
{
    public class LoginController : Controller
    {

        public LoginModel loginModel = new LoginModel();
        // GET: Login

        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel _loginModel)
        {
           

            using (var client = new HttpClient())
            {
               // Create a query
                UriBuilder builder = new UriBuilder("https://localhost:5001/api/login");
                builder.Query = "userName="+_loginModel.Name +"&pass="+_loginModel.Password;
                var responseTask = client.GetAsync(builder.Uri);


                var result = responseTask.GetAwaiter().GetResult();
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    //readTask.Wait();
                    //TempData["loginModel"] = JsonConvert.SerializeObject( loginModel);
                    loginModel = JsonConvert.DeserializeObject<LoginModel>(readTask);
                    TempData["loginModel"] = JsonConvert.SerializeObject(loginModel);
                }


            }
            return RedirectToAction("Index", "HealthDashboard", new { lModel = loginModel });
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}