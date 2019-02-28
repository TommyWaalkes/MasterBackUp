
using APIBreakout.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace APIBreakout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Yelp = GetYelp();
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

      

        //Throughout this whole process it's good to have this open: http://jsonviewer.stack.hu/
        //Simply feed it your API URL and see what comes back, you can use it to keep testing your 
        //URL and to see what data is availible once you have the right URL
        public ActionResult GetWeatherData()
        {
            //Make a request but don't send it yet

            //With this movie API, you put certain parameters into the URL, pay close attention to the documentation 
            //https://forecast.weather.gov/MapClick.php?lat=42.335722&lon=-83.049944&FcstType=json
            //HttpWebRequest request = WebRequest.CreateHttp("http://www.omdbapi.com/?apikey=48e02a80&s=star wars");
            HttpWebRequest request = WebRequest.CreateHttp("https://forecast.weather.gov/MapClick.php?lat=42.335722&lon=-83.049944&FcstType=json");

            //Tell it the list of browsers we're using
            request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

            //If you need to use OAuth or Keys there will be a few extra steps right around here you go on to 
            //grab a response.
            //push the request over to the remote server 
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Parse the response data (this looks a lot like reading in a text file, file I/O)
            StreamReader rd = new StreamReader(response.GetResponseStream());

            //Return the data in string format 
            String data = rd.ReadToEnd();

            //This is where things change based upon whether we're using XML or Json
            //Personally I prefer JSON, but they're equivalent to each other
            JObject o = JObject.Parse(data);

            //Now we can step through the JSON data 
            //the way to approach this is to think of every tag either contains a string array or points 
            //to another list. As you try to construct this always always have the JSON viewer open
            //With the array portion you can use  the .ToList() or ToArray() methods to make a collection
            //of JTokens
            
            //You can step through data just like an array
            //Json works as a series of nested tags 
            //So for example on our weather data has a time header tag 
            //if we want the first item from inside of there we got o["weather"][0]
            List<JToken> times =  o["time"]["startPeriodName"].ToList();
            List<string> temps = new List<string>();
            List<string> forecasts = new List<string>();
            ////https://stackoverflow.com/questions/9198426/mvc3-putting-a-newline-in-viewbag-text
            ////You want the front end to care about presenting data, so we do our newlines there
            JToken region = o["location"]["region"];
            ViewBag.r = region;
            for (int i = 0; i < o["data"]["text"].Count(); i++)
            {
                //string timeLabel = times[i].ToString();
                //string input = o["time"]["startPeriodName"][i].ToString() + " " + o["time"]["tempLabel"][i].ToString() + " " + o["data"]["text"][i].ToString();
                string forecast = o["data"]["text"][i].ToString();
                //temps.Add(input);
               forecasts.Add( forecast);
            }
            //ViewBag.AllTemps = temps;

            ViewBag.Forecasts = forecasts;
            

            return View("Data");
        }

        public ActionResult RandomPokemon()
        {
            Random r = new Random();
            int pick = r.Next(1,803);
            return SearchByNumber(pick);
        }

        public ActionResult SearchByNumber(int pokeNum)
        {

            HttpWebRequest request = WebRequest.CreateHttp("http://pokeapi.co/api/v2/pokemon/" + pokeNum);

            //This line is commented out since Poke API otherwise throws a 403 error
            //request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            String data = rd.ReadToEnd();
            
            JObject o = JObject.Parse(data);

             string name = o["name"].ToString();

            ViewBag.name = name;
            ViewBag.Data = o["sprites"]["front_default"].ToString();
            return View("PokeResult");
        }

        public ActionResult PokemonPicker()
        {

            return View();
        }

        public ActionResult PokeResult()
        {
            return View();
        }

        public ActionResult Data()
        {
            return GetWeatherData();
        }

        public ActionResult Census()
        {
            //https://api.census.gov/data/2016/acs/acs1/profile?get=NAME,DP02_0001E,DP02_0002E,DP02_0003E&for=state:26&for=cd115:*
            HttpWebRequest request = WebRequest.CreateHttp("https://api.census.gov/data/2016/acs/acs1/profile?get=NAME,DP02_0001E,DP02_0002E,DP02_0003E&for=state:26&for=cd115:*");


            //This line is commented out since Poke API otherwise throws a 403 error
            //request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
            request.Headers.Add("X-Census-Key", "f2207d33f1dd624b0ce2e3958ad8d53f59988944"); // used to add keys.
            
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            String data = rd.ReadToEnd();

            JObject o = JObject.Parse(data);
            ViewBag["output"] = o;
            return Census();
        }

        public ActionResult Reddit()
        {
            HttpWebRequest request = WebRequest.CreateHttp("https://www.reddit.com/r/nba/.json");
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string data = rd.ReadToEnd();

            JObject redditJson = JObject.Parse(data);

            List<JToken> posts = redditJson["data"]["children"].ToList();

            List<RedditPost> output = new List<RedditPost>();
            for(int i = 0; i < posts.Count; i++)
            {
                RedditPost rp = new RedditPost();
               
                rp.Title = posts[i]["data"]["title"].ToString();
                rp.ImageURL = posts[i]["data"]["thumbnail"].ToString();
                rp.LinkURL = "http://reddit.com/"+posts[i]["data"]["permalink"].ToString();
                output.Add(rp);
            }

            return View(output);
        }

        public string GetYelp()
        {
            string search = "toy+story";
            string key = "Bearer zBGLzGPy0QLYi5bumq45twGi0iQgH6sd6LrIiPTzrQlMbSG0-_ZyKb8r_6UGvkLVcBQ1GCtFYOJ1mjDjOKEU1mg_JMjV_m3aSUws30HfdWgeQAoUKwgKi975jiwAXHYx";
            string url = "https://api.yelp.com/v3/businesses/search?location=NYC";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", key);

            HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(webResponse.GetResponseStream());

            string data = rd.ReadToEnd();

            return data;
        }

    }
}