using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface Vehicle
    {
         void Drive();
         void Brake();

        int Maxspeed
        {
            get;
        }
        
    }
}
