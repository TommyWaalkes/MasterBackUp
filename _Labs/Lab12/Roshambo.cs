using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Roshambo
    {
        private List<String> rosh;
        public Roshambo()
        {
            rosh = new List<string>();
            rosh.Add("Rock");
            rosh.Add("Paper");
            rosh.Add("Scissors");
        }

        public string GetRoshambo(int index)
        {
            string ro = rosh[index];
            return ro;
        }
    }
}
