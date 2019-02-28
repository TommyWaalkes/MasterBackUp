using System;

namespace ClockImproved
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 12;
            int minutes = 0;
            PrintTime(hour, minutes);

            for(int i = 0; i < 10; i++)
            {
                minutes++;
                PrintTime(hour, minutes);
            }

        }

        static void PrintTime(int hour, int minutes)
        {
            if (minutes < 10)
            {
                Console.WriteLine("The Current Time is " + hour + ":0" + minutes);
            }
            else
            {
                Console.WriteLine("The Current Time is " + hour + ":" + minutes);
            }
        }
    }
}