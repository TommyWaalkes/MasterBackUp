using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car : Vehicle
    {
        public int Maxspeed { get => Maxspeed; }
        private int currentSpeed = 0;
        public void Brake()
        {
            currentSpeed = 0; 
        }

        public void Drive()
        {
            currentSpeed++;
        }

        public void PrintSpeed()
        {
            Console.WriteLine(currentSpeed);
        }
    }
}
