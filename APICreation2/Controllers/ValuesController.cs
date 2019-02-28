using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICreation2.Controllers
{
    public class ValuesController : ApiController
    {
        public string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday","Friday", "Saturday" };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return days;
        }

        // GET api/values/5
        public string Get(int id)
        {
            try
            {
                return days[id];
            }
            catch(Exception e)
            {
                return "Sorry, input index was out of range, please input 1-7";
            }
        }
    }
}
