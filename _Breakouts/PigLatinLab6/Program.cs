using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to the pig latin translator");
            Console.WriteLine("Please input a word to translate: ");

            string input = Console.ReadLine();

            input = input.ToLower();
            Console.WriteLine(input);

            char[] letters = input.ToCharArray();
            PrintCharArray(letters);

            char firstLetter = letters[0];

            if (IsVowel(firstLetter))
            {
                input = input + "way";
            }
            else
            {
                handleConsonant(letters, input);
            }
            Console.WriteLine(input);

        }

        public static string handleConsonant(char[] word, string input)
        {
            string prefix = "";
            string postfix = "";
            string output = "";
            for (int i = 0; i<word.Length; i++)
            {
                char letter = word[i];
                if (IsVowel(letter))
                {
                    prefix = input.Substring(i);
                    postfix = input.Substring(0, i);
                    Console.WriteLine(prefix+postfix + "ay");
                    output = prefix + postfix + "ay";


                }
            }

            return output;
        }

        public static void PrintCharArray(char[] word)
        {
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
        }

        public static bool IsVowel(char c)
        {
            char[] vowels = {'a','e','i','o','u' };

            foreach(char vowel in vowels)
            {
                if (c == vowel)
                {
                    return true;
                }
            }

            return false;
        }


    }
}
