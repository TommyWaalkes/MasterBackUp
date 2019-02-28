using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            ErrorOne();
            ErrorTwo();
            ErrorThree();
        }

        public static void ErrorOne()
        {
            //This isn't running why?
            for(int i = 0; i > 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ErrorTwo()
        {
            Console.WriteLine("What is your age?");

            if (IsOdd(int.Parse(Console.ReadLine())) != false)
            {
                Console.WriteLine("Your age is an odd number");
            }
            else
            {
                Console.WriteLine("Your age is an even number");
            }
        }

        public static bool IsOdd(int num)
        {
            if(num% 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ErrorThree()
        {
            int a = 10;
            int b = 15;
            int c = 5;

            //This should return 25 
            int result = a + b /c;
            Console.WriteLine("25 should be the answer, but the real one is " + result);

        }
    }
}
