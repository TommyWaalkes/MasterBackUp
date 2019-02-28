using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class MovieDB
    {
       private List<Movie> movies;

        public MovieDB(List<Movie> movies)
        {
            this.movies = movies;
        }

        public void PrintByCategory(string cat)
        {
            bool foundSomething = false;

            foreach (Movie m in movies)
            {
                string movieCat = m.getCategory();
                if (movieCat == cat)
                {
                    Console.WriteLine(m.getTitle() + " is a "+cat+" movie");
                    foundSomething = true;
                }

            }
            if(foundSomething == false)
            {
                Console.WriteLine("That category isn't in the database");
            }
        }
    }
}
