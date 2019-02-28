using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise
{
    class FoodModel : Model
    {
        public string name {get; }
        public int calories { get; }
        public bool isHealthy { get; }

        public FoodModel(String name, int calories, bool isHealthy)
        {
            this.name = name;
            this.calories = calories;
            this.isHealthy = isHealthy;
        }

        public string GetStats()
        {
            string output = name;
            output += calories +" Calories";
            output += "It's green";

            return output;
        }
    }
}
