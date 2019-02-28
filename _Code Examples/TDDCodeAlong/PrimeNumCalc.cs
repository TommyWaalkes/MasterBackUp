using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCodeAlong
{
    class PrimeNumCalc
    {
        public bool IsPrime(int num)
        {
            if (IsEven(num))
            {
                return false;
            }
            else
            {
                for(int i = num; i>=3; i -= 2)
                {
                    if (i == num)
                    {
                        continue;
                    }
                    if(num%i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public bool IsEven(int num)
        {
            if(num%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
