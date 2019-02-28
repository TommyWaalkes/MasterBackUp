using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven
{
    class MainRoutine
    {
        static void Main(string[] args)
        {
            Oven o = new Oven();
            Cake c = new Cake("Chocolate", "Confetti", 160);
            Cake c1 = new Cake("Strawberry", "Cream Cheese", 140);
            bool done = c.GetDone();
            Console.WriteLine(done);
            Cake c_done = o.Bake(c);
            c1 = o.Bake(c1);

            Console.WriteLine(c_done.GetDone());
        }

    }
}
