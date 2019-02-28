using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD
{
    class NumstoWordConverter
    {
        public string[] nums = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public string[] tens = {"","ten", "twenty","thirty","forty", "fifty", "sixty", "seventy","eighty","ninety" };
        public string Convert(int i)
        {
            if (i < 10)
            {
                return nums[i];
            }
            else if(i>19 && i < 100)
            {
                return GetTens(i);
            }

            return "negative one";
        }

        //take in a num 1-9 and output the correct 10s place
        //This method isn't work how do we fix it to make the test happy?
        public string GetTens(int i)
        {
            if (i > 9)
            {
                //we cut i apart
                string num = i.ToString();

                string tenPlace = num.Substring(1);

                int output = int.Parse(tenPlace);
                return GetTens(output);
            }
            else
            {
                return tens[i];
            }
        }
    }
}
