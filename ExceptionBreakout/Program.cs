using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBreakout
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool tryagain;
            try
            {
                Console.WriteLine("Please input a number");
                string input = Console.ReadLine();
                num = int.Parse(input);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Num has been set to 0");
                num = -1;
                tryagain = true;
            }
            Console.WriteLine("Hey we got down here");
            Console.WriteLine(num);
        }
    }
}
