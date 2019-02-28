using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPrework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 10;

            if (true)
            {
                t = 3;
                Console.WriteLine(t);
            }
            Console.WriteLine(t);

            Console.WriteLine("Hello and welcome to the GC calculator app");
            Console.WriteLine("Please input two numbers with same amount of digits");
            Console.WriteLine();
            string input1 =null, input2 = null;
            try
            {
                Console.WriteLine("Please input your first number:");
                input1 = Console.ReadLine();
                Console.WriteLine("Please input your second number:");
                input2 = Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.WriteLine("Your input cannot be parsed into an int");
                Console.WriteLine("Please try again!");
                Console.WriteLine(e.StackTrace); 
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            if(input1.Length == input2.Length)
            {
                //int a = int.Parse(input1);
                //int b = int.Parse(input2);

                int i = 0;
                int[] totals = new int[input1.Length];
                while (i < input1.Length)
                {
                    char num1 = input1[i];
                    char num2 = input2[i];

                    int a = int.Parse(num1.ToString());
                    int b = int.Parse(num2.ToString());
                    totals[i] = a + b;
                    Console.WriteLine(totals[i]);
                    i++;
                }
                int total = totals[0];
                bool allSame = true;
                for(int j = 1; j<totals.Length; j++)
                {
                    if(totals[j] != total)
                    {
                        allSame = false;
                        break;
                    }
                }
                Console.WriteLine(allSame);

            }
            else
            {
                Console.WriteLine("Your inputs do not have equal length, please try again!");
            }
        }
    }
}
