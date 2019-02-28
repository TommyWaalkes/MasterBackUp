using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the GC date comparer!");
            Console.WriteLine("Please enter a date formatted like so: MM/DD/YYYY");
            String date1 = Console.ReadLine();
            Console.WriteLine("Please enter a second date formatted like so: MM/DD/YYYY");
            String date2 = Console.ReadLine();

            DateTime firstDate = DateTime.Parse(date1);
            DateTime secondDate = DateTime.Parse(date2);
            //int output =  DateTime.Compare(firstDate, secondDate);
            TimeSpan t = firstDate.Subtract(secondDate);
            
            Console.WriteLine("Total Days: " + Math.Abs(t.TotalDays));
            Console.WriteLine("Total Hours: " + Math.Abs(t.TotalHours));
            Console.WriteLine("Total Minutes: " + t.TotalMinutes);

        }
    }
}
