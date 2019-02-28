using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab12Breakout
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer p = new User();

            IPlayer p2 = null;
           
            bool runAgain = true;
            while(runAgain == true)
            {
                Console.WriteLine("Which opponent would like to face, put in rock for rock or rando for random");
                String input = Console.ReadLine();
                if(input == "rock")
                {
                    p2 = new Rocky();
                    runAgain = false;
                }
                else if (input == "rando")
                {
                    p2 = new Randy();
                    runAgain = false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that let's try that again");
                }

            }
            Console.WriteLine("Player User throws " + p.GetRoshambo());
            Console.WriteLine("Player 2 throws " + p2.GetRoshambo());

        }
    }
}
