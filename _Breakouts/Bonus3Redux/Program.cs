using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3Redux
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int numToGuess = GetNumberToGuess(r);
            Console.WriteLine(numToGuess);
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Please guess an int between 1 and 100");
                string input = Console.ReadLine();

                int guess = int.Parse(input);


                if (guess == numToGuess)
                {
                    Console.WriteLine("Good work you found it");
                    Console.WriteLine("The number is " + numToGuess);
                    run = false;
                }
                else if (guess > numToGuess)
                {
                    if (guess > numToGuess + 10)
                    {
                        Console.WriteLine("Way too high!");
                    }
                    else
                    {
                        Console.WriteLine("Too high");
                    }
                }
                else if (guess < numToGuess)
                {
                    if (guess < numToGuess - 10)
                    {
                        Console.WriteLine("Way too low!");
                    }
                    else
                    {
                        Console.WriteLine("Too low!");
                    }
                }
            }
        }

        public static int GetNumberToGuess(Random rando)
        {
            int output = rando.Next(1,101);
            return output;
        }
    }
}
