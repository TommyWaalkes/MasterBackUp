using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bigger projects like this is where you'd want to care much more about comments
            Player one = new Player("Beefcake Mcgee", 1000);
            Player two = new Player("Wimpy Wimperson", 2);
            Game g = new Game(one, two);
            g.Play();
        }
    }
}
