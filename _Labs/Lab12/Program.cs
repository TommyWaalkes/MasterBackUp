using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rando = new Random();
            Roshambo r = new Roshambo();


            IPlayer p = new RockPlayer("Rocky");


            IPlayer p2 = new PlayerRandom("Vicky", rando);
            IPlayer p1 = new UserPlayer();
            IPlayer p4 = new RockPlayer("Dwane");
            IPlayer p3 = new ScissorsPlayer("Sally");


            RPSApp app = new RPSApp(p4, p3);

         
            Console.WriteLine(app.Play());





        }
    }
}
