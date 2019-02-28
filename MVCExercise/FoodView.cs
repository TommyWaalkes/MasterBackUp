using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise
{
    class FoodView : View
    {
        string name;
        string displayInfo;
        public FoodView(string name, string displayInfo)
        {
            this.name = name;
            this.displayInfo = displayInfo;
        }

        public void DisplayToConsole()
        {
            Console.WriteLine("Guamole Facts");
            Console.WriteLine(displayInfo);

        }
    }
}
