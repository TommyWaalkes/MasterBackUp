using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCodeAlong
{
    class FizzBuzz
    {
        public string EvaluateNum(int num)
        {
            if(num >= 1 && num<=100)
            {
                if(num % 5 == 0)
                {
                    return "Buzz";
                }
                return "Fizz";
            }
            else
            {
                return "NotInRange";
            }

            return null;
        }
    }
}
