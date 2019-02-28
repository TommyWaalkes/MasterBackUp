using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeting = "Hello World";

            var subResult = greeting.Substring(0, 5);

            Console.WriteLine(subResult);

            var subResult2 = subResult.Substring(3, 2);

            Console.WriteLine(subResult2);
        }
    }
}