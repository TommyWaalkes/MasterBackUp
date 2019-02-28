using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD
{
    class FizzBuzz
    {
        public string IsEven(int x)
        {
            if (x <= 3)
            {
                return "prime";
            }
            else if (x % 2 == 0 )
            {
                return "even";
            }
            else
            {
                for(int i = x - 2; i>=3; --i)
                {
                    if (x % i == 0)
                    {
                        return "odd";
                    }
                }
                return "prime";
            }
        }
    }
}
