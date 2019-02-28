using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleObjects
{
    class Game
    {
        private Player p1 { get; set; }
        private Player p2 { get; set; }
        private Player winner { get; set; }
         public Game(Player p1, Player p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            Console.WriteLine("Game start!");
        }

        public void Play()
        {
            //Test your might! 
            int str1 = p1.strength;
            int str2 = p2.strength;
            Console.WriteLine(p1.name + " and "+ p2.name +" grapple!");
            if (str1 > str2)
            {
                winner = p1;
            }
            else if(str1 < str2)
            {
                winner =  p2;
            }
            else
            {
                winner = new Player("No one", 0);  
            }
            DeclareWinner();
        }

        public void DeclareWinner()
        {
            Console.WriteLine(winner.name + " Wins with "+ winner.strength + " strength!");
        }
    }
}
