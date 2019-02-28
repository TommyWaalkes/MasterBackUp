using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StarWarsAPIExample.Controllers
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
            List<JToken> people = GetPerson();
            List<string> names = new List<string>();
           for(int i = 0; i < people.Count; i++)
            {
                JToken person = people[i];
                string name = person["name"].ToString();
                names.Add(name);
            }
            ViewBag.Names = names;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<JToken> GetPerson()
        {
            string URL = "https://swapi.co/api/people/";

            HttpWebRequest request = WebRequest.CreateHttp(URL);

            //request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

            //If any special setup is required it's usually done around here

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //how do we get data from a response?
            StreamReader sr = new StreamReader(response.GetResponseStream());

            string APIText = sr.ReadToEnd();
            //Now we're moving into the parsing step

            JToken personData = JToken.Parse(APIText);

            List<JToken> people = personData["results"].ToList();

            return people;
        }
    }
}