using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Breakout
{
    class Randy : IPlayer
    {
        Random r = new Random();
        String[] rps = { "rock", "paper", "scisscors" };
        public string GetRoshambo()
        {
            int choice = r.Next(0, rps.Length);
            string output = rps[choice];
            return output;
            
        }
    }
}
