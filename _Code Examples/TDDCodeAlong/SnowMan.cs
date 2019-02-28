using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCodeAlong
{
    public class SnowMan
    {
        public bool IsMelting(int temp)
        {
            if (temp <= 32)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
