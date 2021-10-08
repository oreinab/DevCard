using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {

        //return view with layout
        //public IActionResult Index()
        //{
        //    return View("footer");
        //}


        //just return prtialview
        //public IActionResult Index()
        //{
        //    return PartialView("footer");
        //}


        //return html
        //public ContentResult Index()
        //{
        //    return Content($"<h1>helooo friends</h1><script>confirm('myquestion');</script>");
        //}


        //read file
        //public FileResult Index()
        //{
        //    var readFile = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "testff.txt";

        //    return File(readFile,MediaTypeNames.Text.Plain,fileName);
        //}

        //public JsonResult Index()
        //{
        //    return Json(
        //        new
        //        {
        //            id = 1,
        //            name = "test",
        //            work = "developer"
        //        });

        //}

        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult("messagebox.show('jshgdsjhghgds!!!!!')");
        //}

        //public RedirectToActionResult Index()
        //{
        //    //return RedirectToAction("Contact", "Home");
        //}

        //public RedirectResult Index()
        //{
        //    return Redirect("https://google.com");

        //}

        public IActionResult Index()
        {
            //return new OkResult();
            return new StatusCodeResult(404);
        }
    }

    //public class JavaScriptResult :ContentResult
    //{
    //    public JavaScriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "appilcation/javascript";
    //    }

    }

    


