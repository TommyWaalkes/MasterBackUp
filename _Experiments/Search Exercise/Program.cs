using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> goodMovies = new List<string>() { "Lord of the Rings", "Titanic", "Alien", "Aladdin", "Plan 9 from Outer Space", "Saving Private Ryan", "Anchor Man" };
            string s = LongestTitle(goodMovies);
            Console.WriteLine(s);
            Console.WriteLine(s.Length);
            Console.WriteLine("Please enter a movie to add to the list");
            string input = Console.ReadLine();

            goodMovies = AddMovieToList(input, goodMovies);

            PrintList(goodMovies);
            Console.WriteLine();

            Console.WriteLine("Please enter a movie to remove from the list");
            input = Console.ReadLine();
            goodMovies = RemoveFromList(input, goodMovies);
            Console.WriteLine();
            PrintList(goodMovies);
            Console.WriteLine();
            Console.WriteLine("Let's sort the list Alphabetically");

            goodMovies.Sort();
            PrintList(goodMovies);

        }

        public static string LongestTitle(List<string> input)
        {
            int highestLength = 0;
            int highestIndex = -1;


            for(int i = 0; i<input.Count; i++)
            {
                string title = input[i];

                if (title.Length > highestLength)
                {
                    highestLength = title.Length;
                    highestIndex = i;
                }
            }

            string output = input[highestIndex];

            return output;
        }

        public static List<string> AddMovieToList(string movie, List<string> input)
        {
            if (!input.Contains(movie))
            {
                input.Add(movie);
            }
            else
            {
                Console.WriteLine("That movie already exists in the list");
            }

            return input;
        }

        public static List<string> RemoveFromList(string movie, List<string> input)
        {
            if (input.Contains(movie))
            {
                input.Remove(movie);
            }
            else
            {
                Console.WriteLine("That movie is not present in the list");
            }

            return input;
        }

        public static void PrintList(List<string> input)
        {
            Console.WriteLine("Full Movie List:");
            foreach(string movie in input)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
