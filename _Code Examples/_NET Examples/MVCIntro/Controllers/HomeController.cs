using MVCIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Hello = "Hello World! .Net sure is dandy";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Chicken()
        {
            return View();
        }

        public ActionResult HelloWorld()
        {
            return View();
        }

        public ActionResult Product()
        {
            Product p = new Product("Slap Chop", "no idea", 10, 9.99);
            return View(p);
        }

        public ActionResult Product2()
        {
            //Product p = new Product("Jimmy")'
            return View();
        }

        public ActionResult GoodBye()
        {
            return View();
        }
    }
}