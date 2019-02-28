using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSaleman
{
    class City
    {
        private double x = 0;
        private double y = 0;
        private string name;

        public double X { get { return x; } set{ x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public string Name { get { return name; } }

        public City(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public City(Random r, string name)
        {
            this.x = r.Next();
            this.y = r.Next();
        }

        public double CalcDistanceTo(City other)
        {
            double x1 = x;
            double y1 = y;

            double x2 = other.x;
            double y2 = other.y;

            double result = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);

            result = Math.Round(Math.Sqrt(result), 2);

            return result;
        }
    }
}
