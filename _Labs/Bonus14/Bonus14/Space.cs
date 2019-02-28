using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_parking_structures
{
    class Space
    {
        private bool available = true;
        private int size;
        private int id;
        private IVehicle parkedVehicle;

        public Space(int sze, int id )
        {
            if (sze >= 0 && sze <= 3)
            {
                size = sze;
            }
            else
            {
                Console.WriteLine("invalid parking space size.");
                size = -1;
            }
        }
        public bool ParkTheCar(IVehicle v)
        {
            if (available != true)
            {
                Console.WriteLine("Parking spot is not equal to zero");
                return false;
            }
            else
            {
                if (v.GetSize() <= GetSize())
                {
                    available = false;
                    parkedVehicle = v;
                }
                return true;
            }
        }
        public int GetSize()
        {
            return size;
        }
    }
}
