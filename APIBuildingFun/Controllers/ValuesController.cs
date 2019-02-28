using APIBuildingFun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBuildingFun.Controllers
{
    public class ValuesController : ApiController
    {
        public List<Student> Students = new List<Student>() {
            new Student("Paula", 45, "Cooking"),
            new Student("Jimmy", 26, "PE"),
            new Student("Timtom", 27, "History"),
            new Student("Jenifer", 32, "Math")
        };
        
        // GET api/values
        public IEnumerable<Student> Get()
        {
            return Students;
        }

        // GET api/values/5
        public Student Get(int id)
        {
            Student output = Students[id];
            return output;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
