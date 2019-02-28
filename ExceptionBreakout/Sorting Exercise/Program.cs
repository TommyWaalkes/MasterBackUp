using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 30, 86, 9, 75 };
            int big = BiggestNum(nums);
            Console.WriteLine(big);
            Console.WriteLine();

            int[] sorted = SmallestToLargest(nums);
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.WriteLine(sorted[i]);
            }

            Console.WriteLine();

            int[] smallest = LargestToSmallest(nums);
            for (int i = 0; i < smallest.Length; i++)
            {
                Console.WriteLine(smallest[i]);
            }

            Console.WriteLine();
            int[] reversed =  ReverseArray(nums);
            for (int i = 0; i < reversed.Length; i++)
            {
                Console.WriteLine(reversed[i]);
            }

        }

        public static int[] ReverseArray(int[] nums)
        {
            Array.Reverse(nums);
            return nums;
        }

        public static int[] LargestToSmallest(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);

            return nums;
        }

        public static int[] SmallestToLargest( int[] nums)
        {
             Array.Sort(nums);
 
            return nums;
        }

        public static int BiggestNum(int[] nums)
        {
            int biggest = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (biggest < num)
                {
                    biggest = num;
                }
            }
            return nums.Max();
        }
    }
}
