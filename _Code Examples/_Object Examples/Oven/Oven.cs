using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven
{
    class Oven
    {
        private int temp = 0;
        public Cake Bake(Cake c)
        {
            if (c.GetDone() == true)
            {
                Console.WriteLine("That cake is already baked, yo");
                return c;
            }
            else
            {
                int expectedTemp = c.GetBakingTemp();
                bool hotEnough = false;
                while (hotEnough == false)
                {
                    if (expectedTemp == temp)
                    {
                        Console.WriteLine("Your cake is done baking!");
                        c.SetDone(true);
                        hotEnough = true;
                    }
                    else if(expectedTemp>temp)
                    {
                        HeatUp(expectedTemp);
                    }
                    else if (expectedTemp < temp)
                    {
                        CoolDown(expectedTemp);
                    }
                }
                return c;
            }
        }

        public void HeatUp(int temp)
        {
            this.temp = temp;
            Console.WriteLine("The oven has heated up to "+temp+" degrees");
        }

        public void CoolDown(int temp)
        {
            this.temp = temp;
            Console.WriteLine("The oven has cooled down to " + temp + " degrees");
        }
    }
}
