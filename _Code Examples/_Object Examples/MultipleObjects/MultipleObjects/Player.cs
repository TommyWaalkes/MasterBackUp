using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleObjects
{
   
    class Player
    {
        public string name { get; }
        public int strength { get; }
       public Player(string name, int strength)
        {
            this.name = name;
            this.strength = strength;
        }
    }
}
