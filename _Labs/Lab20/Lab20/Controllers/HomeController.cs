using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab20.Models;

namespace Lab20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Register r)
        {
            ViewBag.Message = "Welcome to the Grand Circus Coffee App";
            ViewBag.Name = r.FirstName;
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

        public ActionResult Register()
        {
            ViewBag.Message = "Register with Grand Circus Coffee!";
            return View();
        }

        public ActionResult Success(Register r)
        {
       
            ViewBag.Message = "Welcome " + r.FirstName;
            return View(r);

        }

        [HttpPost]
        public ActionResult SaveToDataBase(Register r)
        {
            Console.WriteLine(r.FirstName);
            try
            {
                using (DBRegisterContext CustData = new DBRegisterContext())
                {
                    CustData.Entries.Add(
                        new Register()
                        {
                            FirstName = r.FirstName,
                            Email = r.Email,
                        });
                    try
                    {
                        CustData.SaveChanges();
                    }
                    catch(Exception e)
                    {
                        ViewBag.Message = e;
                        return View("Error");
                    }
                    return View("Success");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "There was an error in your input" + ex.GetBaseException();
                return View("Error");
            }


        }
    }
}