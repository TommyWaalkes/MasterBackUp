﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "green", "yellow", "red" };
            Country c = new Country("Zimbabwe", "English", "Hello there!", colors);
            CountryController cc = new CountryController();
           // cc.CountryDetails(c);

            Console.WriteLine(c.Name);
            //Console.ForegroundColor =(ConsoleColor)15;
            //Console.WriteLine("What color would you like the background to be?");
            //string color = Console.ReadLine();
            //Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);


            //cc.CountryMenu();
            //string[] colors = { "Red", "White", "Blue" };
            //Country c = new Country("Stankonia", "Stankonese", "Hello world!", colors);
            //cc.CountryDetails(c);
        }
    }
}
