using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise
{
    class Controller
    {
        public void HomePage()
        {
            HomePage hp = new HomePage();

            hp.DisplayToConsole();
        }

        public void FoodView(FoodModel fm)
        {
            FoodView fv = new FoodView(fm.name, fm.GetStats());

            fv.DisplayToConsole();
        }
    }
}
