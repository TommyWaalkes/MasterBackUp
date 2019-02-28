using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller c = new Controller();
            c.HomePage();
            FoodModel f = new FoodModel("Orange",100,true);
            c.FoodView(f);
        }
    }
}
