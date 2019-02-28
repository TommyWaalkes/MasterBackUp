using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number to calculate the factorial");
            string input = Console.ReadLine();
            int num;
            bool worked = int.TryParse(input, out num);
            if (worked == true)
            {
                int output = LoopFactorial(num);
                Console.WriteLine("The Factorial of "+ num +" is "+output);
            }
            else
            {
                Console.WriteLine("Hey that input was not a valid int");
            }
           
        }

        public static int LoopFactorial(int input)
        {
            int total = 1;
            for(int i = input; i>= 1; i--)
            {
                Console.WriteLine(i);
                total *= i;
            }

            return total;
        }

        public static int Factorial(int input)
        {
            int timesRun = 1;
            int total = 1;
            int result;
           
            result = RecurFactorial(input, timesRun, total);
           
            return result;
        }

        public static int RecurFactorial(int input, int timesRun, int total)
        {
            if (timesRun > input)
            {
                //End Condition, stop when we get here 
                return total;
            }
            else
            {
                
                Console.WriteLine(timesRun);
                total *= timesRun;
                timesRun++;
                return RecurFactorial(input, timesRun, total);
            }
        }
    }
}
