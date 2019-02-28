using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLine
{
    class Battle : HistoricalEvent
    {
        string outcome;
        //Make a battle against puns class, no one won 
        public Battle(int y, string n, string d, bool b, String o)
            :base(y,n,d,b)
        {
            outcome = o;
        }

        public string OutCome()
        {
            return outcome;
        }

        public void PrintDetails()
        {
            if (IsAD == true)
            {
                Console.WriteLine("In Year " + year + " AD");
            }
            else
            {
                Console.WriteLine("In Year " + year + "BC");
            }
            Console.WriteLine("The " + name + " Happened");
            Console.WriteLine(description);
            Console.WriteLine(outcome);
            Console.WriteLine();
        }
    }
}
