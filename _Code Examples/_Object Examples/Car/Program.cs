using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Toyota();

            c.Drive();

            c.PrintSpeed();
        }
    }
}
