using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLine
{
    abstract class HistoricalEvent
    {
        protected int year;
        protected String name;
        protected String description;
        protected bool IsAD;

        public HistoricalEvent(int year, string name, string description, bool IsAD)
        {
            this.year = year;
            this.name = name;
            this.description = description;
            this.IsAD = IsAD;
        }

        public int GetYear()
        {
            return year;
        }

        public void PrintDetails()
        {
            if (IsAD == true)
            {
                Console.WriteLine("In Year " + year +" AD");
            }
            else
            {
                Console.WriteLine("In Year " + year + "BC");
            }
            Console.WriteLine("The " + name +" Happened");
            Console.WriteLine(description);
            Console.WriteLine();
        }


    }
}
