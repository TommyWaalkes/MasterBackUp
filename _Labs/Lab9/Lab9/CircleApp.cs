using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class CircleApp
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            int count = 0;
            while (goOn==true)
            {
                Console.WriteLine("Hello welcome to the Circle APP");
                Console.WriteLine("Please input a radius for your circle.");
                double r = double.Parse(Console.ReadLine());
                //double s = double.Parse("Tommy Waalkes");

                Circle c = new Circle(r);
                //Circle d = new Circle();
                count++;

                Console.WriteLine(c.GetFormattedCircumference());
                Console.WriteLine(c.GetFormattedArea());

                goOn = Continue();
            }
            Console.WriteLine("You made "+count+" circles");
        }

        public static Boolean Continue()
        {
            Console.WriteLine("Continue? Y/N");
            string input = Console.ReadLine();
            Boolean run = false;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Good bye");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't under your input let's try that again");
                run = Continue();
            }

            return run;
        }
    }
}
