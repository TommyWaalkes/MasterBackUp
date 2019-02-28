using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program
    {
        public static int[] nums = new int[100];
        static void Main(string[] args)
        {
            FillOutArray();
            Console.WriteLine("Welcome! I have populated an array of int, each one picked at random");
            Console.WriteLine("We have no idea what'll be in our array!");
            Console.WriteLine("What number would you like to search for?");
            int input = int.Parse(Console.ReadLine());

            int index = LinearSearch(input);
            if (index != -1)
            {
                Console.WriteLine($"Found {input} at index {index}");
            }
            else
            {
                Console.WriteLine($"{input} was not found!");
            }

            int index2 = BinarySearch(input, 1, nums.Length, 0);
        }

        public static int LinearSearch(int input)
        {
            //While yes we can use indexOf and .Contains, this is what the computer is doing under the hood
            //Oftentime we can't use those methods, in particular when we work with objects
            //Therefore, knowing linear search is critical!
            //Unless we care about efficency, this is the search method you to default to!
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Linear Tries: {i}");
                if(nums[i] == input)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearch(int input, int min, int max, int tries)
        {
            tries++;
            if (min > max)
            {
                return -1;
            }
            else
            {
                int mid = (min + max) / 2;
                if (input == nums[mid])
                {
                    Console.WriteLine($"it took binary search {tries} tries to find {input}");
                    return ++mid;
                }
                else if (input < nums[mid])
                {
                    return BinarySearch(input, min, mid - 1, tries);
                }
                else
                {
                    return BinarySearch(input, mid + 1, max, tries);
                }
            }
        }



        public static void FillOutArray()
        {
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
        }
    }
}
