using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLine
{
    class FoundingOfRome : HistoricalEvent
    {
        public FoundingOfRome() 
            :base(754, "Founding of Rome", "Romulus and Remus founded a city", false)
        {

        }

        public void RomansAreCool()
        {
            Console.WriteLine("Gauls drool Roman rule");
        }
    }
}
