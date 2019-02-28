using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_parking_structures
{
     
    interface IVehicle
    {
        int GetSize();

    }
    class Motorcycle : IVehicle
    {
        private int size;

        public int GetSize()
        {
            size = 1;
            return 1;
        }
    }
    class Car : IVehicle
    {
        private int size;
        public int GetSize()
        {
            size = 2;
            return 2;
        }
    }
    class Bus : IVehicle
    {
        private int size;

        public int GetSize()
        {
            size = 3;
            return 3;
        }
    }
}
