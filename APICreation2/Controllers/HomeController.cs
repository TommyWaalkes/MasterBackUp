using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace APICreation2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //HttpWebRequest request = HttpWebRequest.CreateHttp("http://localhost/api/values");
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
 


            //StreamReader sr = new StreamReader(response.GetResponseStream());
            //string data = sr.ReadToEnd();

            //ViewBag.day = data;

            return View();
        }
    }
}
