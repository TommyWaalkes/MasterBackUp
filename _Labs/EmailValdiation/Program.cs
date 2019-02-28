using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValdiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an email in this format: ");
            Console.WriteLine("user@example.com");

            string intput = Console.ReadLine();
            Console.WriteLine("Please input a password with at least one capitol");
            string input2 = Console.ReadLine();

            ValidatePassword(input2);


        }

        public static bool ValidateEmail(string email)
        {
            return false;
        }

        public static bool ValidatePassword(string password)
        {
            if (IsLongEnough(password))
            {
                Console.WriteLine("Great! Your password is 5 or more characters long!");
                if (HasCapital(password))
                {
                    Console.WriteLine("The password has a capital!");
                    if (HasNumber(password))
                    {
                        Console.WriteLine("The password has one or more numbers!");
                    }
                    else
                    {
                        Console.WriteLine("There was not at least one number in the password");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("There was not at least one Capital letter");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but your password was not 5 or more characters");
            }
            return false;
        }

        public static bool IsLongEnough(string password)
        {
            int plenght = password.Length;

            if(plenght>= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HasNumber(string password)
        {
            foreach(char c in password)
            {
                if(c>= '0' && c <= '9')
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasCapital(string password)
        {
            foreach(char c in password.ToCharArray())
            {
                if(c >='A'&& c <= 'Z')
                {
                    return true;
                }
            }

            //if we get here we went through the whole array
            return false;
        }
    }
}
