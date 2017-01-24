using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index()
        {
            ViewBag.Message = "Home Page";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Page";
            return View();
        }
    }
}