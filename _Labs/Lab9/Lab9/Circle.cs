using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{

    class Circle
    {
        private double radius;
        public const double pi = Math.PI;
        public string hi = "hi";
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            double circum = 2 * pi * radius;
            return circum;
        }

        public string GetFormattedCircumference()
        {
            double cir = GetCircumference();
            string formattedCir = GetFormattedNumber(cir);
            string output = "The Circumference of your circle is "+ formattedCir;
            return output;
        }

        public double GetArea()
        {
            double area = pi * radius * radius;
            return area;
        }

        public String GetFormattedArea()
        {
            double area = GetArea();
            string formattedArea = GetFormattedNumber(area);
            string output = "The Area of your circle is " + formattedArea;
            return output;
        }

        private string GetFormattedNumber(double x)
        {
            double d = Math.Round(x, 2);
            return d.ToString();
        }
    }
}
