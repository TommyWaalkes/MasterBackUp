using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class ScissorsPlayer : IPlayer
    {
        private string name;
        public ScissorsPlayer(string name)
        {
            this.name = name;
        }

        public string GenerateRoshambo()
        {
            Roshambo r = new Roshambo();
            string result = r.GetRoshambo(2);
            return result;

        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string n)
        {
            this.name = n;
        }
    }
}
