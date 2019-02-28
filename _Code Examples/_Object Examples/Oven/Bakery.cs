using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven
{
    class Bakery
    {
        private List<Cake> cakes = new List<Cake>();

        public void AddCake(Cake c)
        {
            if (c.GetDone() == true)
            {
                cakes.Add(c);
            }
            else
            {
                Console.WriteLine("That cake hasn't been baked");
            }
        }
    }
}
