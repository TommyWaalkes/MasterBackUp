using StoreFront.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreFront.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Store()
        {
            return View();
        }

        public ActionResult Result(string CandyName)
        {
            Product p = new Product();
            p.Name = CandyName;

            switch (p.Name)
            {
                case "Skittles":
                    p.Cost = 1.05;
                    break;
                case "Airheads":
                    p.Cost = 5.45;
                    break;
                case "MMs":
                    p.Cost = 2.99;
                    break;
            }

            ViewBag.Candy = p;
            return View();
        }
    }
}