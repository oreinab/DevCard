using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        //Create data in controller level/initialize model 
        private readonly List<Service> lstServices = new List<Service>
        {
            new Service(1,"gold"),
            new Service(1,"silver"),
            new Service(1,"boronz"),
            new Service(1,"platin")

        };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Servieces =new SelectList(lstServices,"Id","Name")
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult Contact(Contact modelContact)
        {
            modelContact = new Contact
            {
                Servieces = new SelectList(lstServices)

            };
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات را دوباره وارد کنید.";
                return View(modelContact);
            }

            ModelState.Clear();
            modelContact = new Contact
            {
                Servieces = new SelectList(lstServices, "Id", "Name")

            };
            ViewBag.success = "اطلاعات ارسال شد";
            return View(modelContact);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}