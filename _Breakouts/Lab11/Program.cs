using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            Movie m = new Movie("Apolo 13", "drama");
            movies.Add(m);
            movies.Add(new Movie("Saving Private Ryan", "drama"));
            movies.Add(new Movie("Water Boy", "comedy"));
            movies.Add(new Movie("Step Brothers", "comedy"));
            movies.Add(new Movie("Texas Chainsaw Massacre","horror"));
            movies.Add(new Movie("Halloween","horror"));

            Console.WriteLine("Please input a movie category");
            string input = Console.ReadLine();
            PrintByCategory(movies, input);
        }

        public static void PrintByCategory(List<Movie> movies, string category)
        {
            Console.WriteLine($"Movies in the {category} category");
            foreach(Movie m in movies)
            {
                if(m.category == category)
                {
                    Console.WriteLine(m.title);
                }
            }
        }
    }
}
