using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_parking_structures
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("How many levels?");
            int levels = int.Parse(Console.ReadLine());
            Console.WriteLine("How many spots per level?");
            int spotsPerLevel = int.Parse(Console.ReadLine());
            // for the number of levels
            // add to the garage levels list the number of spaces
            // if on level 0 or 1 make sure to put first five large spaces together
            var mygarage = new Garage();
            List<Space> spaces = new List<Space>();
            for (int l=0; l < spotsPerLevel; l++)
            {
                spaces.Add(new Space(1, l));
            }

            List<Level> garageLevels = new List<Level>();


            for (int i = 0; i < levels; i++)
            {

                mygarage.levels.Add(new Level(5));
            }

        }
    }
}
