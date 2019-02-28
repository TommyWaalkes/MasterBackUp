using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Breakout
{
    class User : IPlayer
    {
        public string GetRoshambo()
        {          
            bool runAgain = true;
            string output =""; 
            while (runAgain == true)
            {
                Console.WriteLine("Please input r, p, or s");
                string input = Console.ReadLine();
                if (input == "r")
                {
                    runAgain = false;
                    output = "rock";
                }
                else if (input == "p")
                {
                    runAgain = false;
                    output = "paper";
                }
                else if (input == "s")
                {
                    output = "scissors";
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't let's again");
                }
            }
            return output;
        }
    }
}
