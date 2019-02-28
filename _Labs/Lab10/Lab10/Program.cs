using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            Movie m = new Movie("Silence of the Lambs","horror");
            movies.Add(m);
            m = new Movie("Saw", "horror");
            movies.Add(m);
            m = new Movie("Moana", "animated");
            movies.Add(m);
            m = new Movie("IT", "horror");
            movies.Add(m);

            MovieDB db = new MovieDB(movies);

            m = new Movie("Alien","horror");
            movies.Add(m);

            Console.WriteLine("Please put in a movie category");
            string input = Console.ReadLine();
            db.PrintByCategory(input);

            //foreach(Movie cj in movies)
            //{
            //    string cat = cj.getCategory();
            //    if (cat=="horror")
            //    {
            //        Console.WriteLine(cj.getTitle() +" is a horror movie");
            //    }

            //}
        }
    }
}
