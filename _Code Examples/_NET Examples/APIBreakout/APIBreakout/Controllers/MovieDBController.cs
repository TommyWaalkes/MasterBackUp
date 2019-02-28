using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace APIBreakout.Controllers
{
    public class MovieDBController : Controller
    {
        // GET: MovieDB
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchMovie()
        {
            //This key is generated and either sent to my account or email upon sign up for this service
            string myKey = "48e02a80";
            string url = @"http://www.omdbapi.com/?apikey="+myKey+"&s=star wars&r=xml";
            HttpWebRequest webRequest = null;
            webRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse webResponse = null;
            webResponse = (HttpWebResponse)webRequest.GetResponse();

            StreamReader rd = new StreamReader(webResponse.GetResponseStream());

            string data = rd.ReadToEnd();

            XmlDocument xd = new XmlDocument();
            xd.LoadXml(data);
            

            string output = data;
            ViewBag.p = xd.ToString();
            //This don't work, let's fix it! pay attention to the XML
            //What does this method look like?
            ViewBag.Title = xd.GetElementsByTagName("ghdfkjs");
            return View();
        }

        public string SearchMovieByAPI(string movieTitle)
        {
            string APIKey = "f4f88f98";
            string url = "http://www.omdbapi.com/?apikey=" +APIKey+"&t="+movieTitle;
            string awesome = "adam";
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(webResponse.GetResponseStream());

            string data = rd.ReadToEnd();

            

            return data;

          

        }

        public ActionResult MovieResults()
        {
            String data = SearchMovieByAPI("ghost in the shell");

            JObject o = JObject.Parse(data);

            ViewBag.title = o["Title"];
            string actorsString = o["Actors"].ToString();
            string[] actors = actorsString.Split(',');

            ViewBag.actors = actors;

            ViewBag.ImgPath = o["Poster"];

            ViewBag.dat = data;

            return View();
        }

public ActionResult Movie()
        {
            string search = "toy+story";
            string key = "6b0b6729c5a253576b09b3563711188f";
            string url = "https://api.themoviedb.org/3/search/movie?api_key=" + key + "query=" + search;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(webResponse.GetResponseStream());

            string data = rd.ReadToEnd();

            ViewBag.Result = data;

            return View();

        }

    }
}