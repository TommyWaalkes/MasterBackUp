using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RPSApp
    {
        IPlayer player1;
        IPlayer player2;
        public RPSApp(IPlayer p1, IPlayer p2)
        {
            player1 = p1;
            player2 = p2;
        }

        public string Play()
        {
            string p1_result = player1.GenerateRoshambo();
            string p2_result = player2.GenerateRoshambo();
            string result ="";
            Console.WriteLine(player1.GetName() +" throws " + p1_result);
            Console.WriteLine(player2.GetName()+" throws " +p2_result);

            result = DecideWinner(player1, player2, p1_result, p2_result);

            return result;
        }

        public string DecideWinner(IPlayer p1, IPlayer p2, string p1_result, string p2_result)
        {
            Console.WriteLine(p1_result);
            p1_result = p1_result.ToLower();
            p2_result = p2_result.ToLower();
           
            string result = "NA";
            if (p1_result == p2_result)
            {
                //Draws
                result = p1.GetName() + " and " + p2.GetName() + " draw";
            }
            else
            {
                //Wins for player one
                //Check yo spelling
                if (p1_result == "rock" && p2_result == "scissors")
                {
                    result = p1.GetName() + " beats " + p2.GetName();
                }
                else if (p1_result == "paper" && p2_result == "rock")
                {
                    result = p1.GetName() + " beats " + p2.GetName();
                }
                else if (p1_result == "scissors" && p2_result == "paper")
                {
                    result = p1.GetName() + " beats " + p2.GetName();
                }
                else if(p2_result == "rock" && p1_result == "scissors")
                {
                    result = p2.GetName() + " beats " + p1.GetName();
                }
                else if (p2_result == "paper" && p1_result == "rock")
                {
                    result = p2.GetName() + " beats " + p1.GetName();
                }
                else
                {
                    result = p2.GetName() + " beats " + p1.GetName();
                }


            }
            return result;
        }
    }
}
