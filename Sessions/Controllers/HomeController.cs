using Sessions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sessions.Controllers
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

        //displays the view 
        public ActionResult Login()
        {
            return View();
        }

        //processes the user input from the form
        [HttpPost]
        public ActionResult Login(string Name, string Password)
        {
            User u = new User(Name, null, Password);
            Session["CurrentUser"] = u;
            Session["CurrentUserName"] = u.Name;

            return View();
        }

        public ActionResult UserDetails()
        {
            if(Session["CurrentUser"] != null)
            {
                User u = (User) Session["CurrentUser"];
                ViewBag.User = u.Name;
            }
            else
            {
                ViewBag.Error = "No user is logged in, please login to see this page";
            }
            return View();
        }

        public ActionResult LogOut()
        {
            //First we clear the current user 
            //Then we redirect to login or index
           Session["CurrentUser"] = null;
            return RedirectToAction("Login");
        }
    }
}