using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    interface IPlayer
    {
        string GetName();

        void SetName(String n);

        String GenerateRoshambo();
    }
}
