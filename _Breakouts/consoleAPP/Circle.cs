using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPP
{
    class Circle
    {
        private double radius;

        public Circle(double r)
        {
            this.radius = r;
        }

        public void PrintRadius()
        {
            Console.WriteLine(radius);
        }
    }
}
