using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] rooms = new bool[10];

            rooms[0] = true;
            rooms[1] = true;

            rooms[7] = true;
            rooms[0] = false;
            for(int i = 0; i < rooms.Length; i++)
            {
               

                if (i==7)
                {
                    rooms[7] = false;
                }
                bool occupied = IsOccupied(rooms, i);
                if (occupied == true)
                {
                    Console.WriteLine("Room " + i + " is occupied");
                }
                else
                {
                    Console.WriteLine("Room "+i+" is vacant");
                }
            }

            
        }

        public static bool IsOccupied(bool[] rooms, int roomNumber)
        {
            bool occupied = rooms[roomNumber];
            return occupied;
        }
    }
}