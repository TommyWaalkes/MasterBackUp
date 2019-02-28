using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class UserPlayer : IPlayer
    {
        private string name;

        public UserPlayer()
        {
            Console.WriteLine("Please Input a name");
            string input = Console.ReadLine();
            SetName(input);
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string n)
        {
            name = n;
        }

        public String GenerateRoshambo()
        {
            
            string result ="";
            Roshambo r = new Roshambo();
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Please Input R/P/S");
                string input = Console.ReadLine();
                if (input == "r")
                {
                    result = r.GetRoshambo(0);
                    run = false;
                }
                else if (input == "p")
                {
                    result = r.GetRoshambo(1);
                    run = false;
                }
                else if (input == "s")
                {
                    result = r.GetRoshambo(2);
                    run = false;
                }
                else
                {
                    result = "error";
                }
                if (result == "error")
                {
                    Console.WriteLine("I didn't understand that Input, please try again");
                    run = true;
                }
            }
            
            return result;
        }
    }
}
