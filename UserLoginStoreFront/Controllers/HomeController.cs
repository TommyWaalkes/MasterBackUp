using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserLoginStoreFront.Models;

namespace UserLoginStoreFront.Controllers
{
    public class HomeController : Controller
    {

        UserDb db = new UserDb();

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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Name, string Password)
        {
            for(int i = 0; i < db.Users.Count; i++)
            {
                User u = db.GetUser(i);
                if(u.Name == Name && u.Password == Password)
                {
                    Session["CurrentUser"] = u;
                    
                }
            }
            return View();
        }

        public ActionResult UserDetails()
        {
            if (Session["CurrentUser"]==null)
            {
                TempData["Error"] = "No user is logged in please log in";
                return RedirectToAction("Login");
            }

            return View();
        }
    }
}