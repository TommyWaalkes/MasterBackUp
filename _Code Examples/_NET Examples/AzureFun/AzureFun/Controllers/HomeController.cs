using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AzureFun.Controllers
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

            return GetData();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetData()
        {
            HttpWebRequest request =
   WebRequest.CreateHttp("http://forecast.weather.gov/MapClick.php?lat=42.335722&lon=-83.049944&FcstType=json");

            //Tells the user what browsers we're using

            request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";



            // request.Headers.Add("X-Mashape-Key",value);

            //actually grabs the request

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //gets a stream of text

            StreamReader rd = new StreamReader(response.GetResponseStream());

            //reads to the end of file

            string ApiText = rd.ReadToEnd();

            //Converts that text into JSON

            JObject weatherData = JObject.Parse(ApiText);



            ViewBag.ApiText = "The Current Temperature is "+ weatherData["data"]["temperature"][0];

            // ViewBag.ApiText = weatherData["data"]["text"][0];



            /*  foreach (var element in weatherData["data"]["temperature"])

              {

                  ViewBag.ApiText += element + ",\n" + Environment.NewLine;

              }



              ViewBag.ApiText = "";



              for (int i = 0; i < 4; i++)

              {

                  ViewBag.ApiText +=" " + weatherData["time"]["startPeriodName"][i] + " ";

                  ViewBag.ApiText += " High " + weatherData["data"]["temperature"][i]+",  ";

              }
              */



            //ViewBag.ApiText = ViewBag.ApiText.Trim(',');



            // ViewBag.ApiText = "Your Forecast is " + weatherData["data"]["temperature"][0];



            return View("About");
        }
    }
}