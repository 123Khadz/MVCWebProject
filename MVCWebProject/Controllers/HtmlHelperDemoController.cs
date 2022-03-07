using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebProject.Controllers
{
    public class HtmlHelperDemoController : Controller
    {
        // GET: HtmlHelperDemo
        public ActionResult Index()
        {
            ViewBag.Courses = new string[] { "C#", "Java", "Php", "MS.Net", "Python" };
            return View();
        }

        public ViewResult StandardHelper()
        {
            ViewBag.Qualification = new string[] { "BCA", "MCA", "BTech", "MTech", "MBA" };
            ViewBag.City = new SelectList(new string[] { "Noida", "Delhi", "Patna", "Gaya", "Lucknow" });
            return View();
        }

        [HttpPost]
        public string StandardHelper(FormCollection form)
        {
            return "Details:" + form["Id"] + "," + form["Name"] + "," + form["gender"] + "," + form["City"];
        }

        public ViewResult TemplatedHelper()
        {
            return View();
        }
    }
}