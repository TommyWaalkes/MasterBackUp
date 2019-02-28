using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 12;
            int minutes = 0;
            if (minutes < 10)
            {
                Console.WriteLine("The starting time is " + hour + ":0" + minutes);
            }
            else
            {
                Console.WriteLine("The starting time is " + hour + ":" + minutes);
            }
            minutes = minutes + 1;
            minutes = minutes + 1;
            minutes++;
            minutes++;
            minutes++;
            minutes++;
            minutes++;
            minutes++;
            minutes++;
            minutes++;
            if (minutes < 10)
            {
                Console.WriteLine("The starting time is " + hour + ":0" + minutes);
            }
            else
            {
                Console.WriteLine("The starting time is " + hour + ":" + minutes);
            }
            minutes++;
        }
    }
}