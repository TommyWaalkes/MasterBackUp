using APICreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICreation.Controllers
{
    public class ValuesController : ApiController
    {
       List<Movie> Movies = new List<Movie>
            {
                new Movie{Id = 1, Name="Saving Private Ryan", Cost=9.99},
                new Movie{Id = 2, Name="Jimmy Dean's Hog high Heaven Rally", Cost=0.89},
                new Movie{Id = 3, Name="Space Jam 2 : Jupiter Jam Slam", Cost=100.33}
            };
        // GET api/values
        public IEnumerable<Movie> Get()
        {
            return Movies;
        }

        // GET api/values/5
        public Movie Get(int id)
        {

            try
            {
                return Movies[id];
            }
            catch(Exception e)
            {
                return new Movie { Id = id, Name = "The requested movie doesn't exist, please try another index", Cost = 0 };
            }
        }

        // POST api/values
        [HttpPost]
        public List<Movie> Post([FromBody]Movie m)
        {
            Movies.Add(m);
            return Movies;
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
