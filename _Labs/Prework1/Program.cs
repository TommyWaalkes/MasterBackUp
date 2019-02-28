using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to the Grand Circus number reverser!");
            Console.WriteLine("Please input a valid number to reverse");
            String input = Console.ReadLine();

           
            int parsedNum;
            bool success = int.TryParse(input, out parsedNum);


            if (success)
            {
                char[] s = input.ToCharArray();
                List<char> reversedNum = s.Reverse().ToList();
                for(int i = 0; i< reversedNum.Count(); i++)
                {
                    Console.Write(reversedNum[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Also! We could just do it this way without using the reverse method");

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    Console.Write(s[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Your input did not parse correctly ");
            }
        }
    }
}
