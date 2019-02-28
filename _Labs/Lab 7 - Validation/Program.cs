using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Hello please pick an option: ");
                Console.WriteLine("1) Validate Name");
                Console.WriteLine("2) Validate Email");
                Console.WriteLine("3) Validate Phone Number");
                Console.WriteLine("4) Validate Date");

                string choice = Console.ReadLine();
                int pick = 0;
                if(int.TryParse(choice, out pick))
                {
                    string s;
                    bool success = false;
                    switch (pick)
                    {
                        case 1:
                            s = getInput("Please enter capitalized name");
                            success = ValidateName(s);
                            Console.WriteLine(success);
                            break;
                        case 2:
                            s = getInput("Please enter an email in this format: example@email.com");
                            success = ValidateEmail(s);
                            Console.WriteLine(success);
                            break;
                        case 3:
                            s = getInput("Please enter a phone number in either format: nnn-nnn-nnnn or nnnyyyxxxx");
                            success = ValidatePhone(s);
                            Console.WriteLine(success);
                            break;
                        case 4:
                            Console.WriteLine("Valid Date Formats:");
                            foreach (var customString in DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns('d'))
                                Console.WriteLine("   {0}", customString);
                            s = getInput("Please enter a date in the correct format");

                            success = ValidateDate(s);
                            Console.WriteLine(success);
                            break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("That was not a number let's try again");
                }
            }
        }

        public static string getInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();

            return output;
        }

        public static bool IsLetter(char c)
        {
            bool l = IsLower(c) || IsCapitol(c);

            return l;
        }

        public static bool IsCapitol(char c)
        {
            if (c >= 'A' && c <= 'Z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsLower(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsNumber(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsAlphaNumeric(char c)
        {
            bool an = IsNumber(c) || IsLetter(c);
            return an;
        }

        public static bool IsWhiteSpace(char c)
        {
            if(c == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool lengthFallsInRange(int min, int max, string input)
        {
            if (input.Length >= min && input.Length <= max)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Your inputed string " + input + " is too long or short at " + input.Length + " characters");
                Console.WriteLine("Please input a prefix between {0} and {1} chars", min, max);
            }

            return false;
        }

        public static bool ValidateName(string name)
        {
            name = name.Trim();

            if (name != null && name.Length > 0)
            {
                if (name.Length <= 30)
                {
                    char[] n = name.ToCharArray();

                    //check the first letter
                    bool firstCapitol = IsCapitol(n[0]);

                    if (firstCapitol)
                    {
                        //check the rest of the word
                        for (int i = 1; i < n.Length; i++)
                        {
                            char c = n[i];
                            if (! (IsLetter(c) || IsWhiteSpace(c)))
                            {
                                return false;
                            }
                        }

                        return true;
                    }
                    else
                    {
                        Console.WriteLine("First letter of the inputed string isn't capitalized.");
                    }
                }
                else
                {
                    Console.WriteLine("inputed name is too long, max characters is 30");
                }
            }
            else
            {
                Console.WriteLine("Empty or null string recieved, invalid input, please try again.");
            }

            return false;
        }

        static bool ValidateEmail(string email)
        {
            if (email.Contains('.') && email.Contains('@'))
            {
                if (email.IndexOf('.') > email.IndexOf('@'))
                {
                    char[] separators = { '.', '@' };
                    string[] parts = email.Split(separators);
                    //Double foreachs aren't great, but are better since the computer handles index for you 
                    foreach (string s in parts)
                    {
                        foreach (char c in s.ToCharArray())
                        {
                            //Return false if there is an alphanumeric at each spot
                            bool goodChar = IsAlphaNumeric(c);
                            if (!goodChar)
                            {
                                return false;
                            }
                        }
                    }
                    string pre = parts[0];
                    bool preGood = lengthFallsInRange(5, 30, pre);

                    string domain = parts[1];
                    bool domainGood = lengthFallsInRange(5, 10, domain);

                    string postFix = parts[2];
                    bool postGood = lengthFallsInRange(2, 3, postFix);

                    //if all three parts are good return true
                    if (postGood && domainGood && postGood)
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("Your email must have a . later than a @");
                }

            }
            else
            {
                Console.WriteLine("Your email does not contain either a . or an @ or both");
            }
            return false;
        }

        static bool ValidatePhone(string phone)
        {
            if (phone.Contains('-'))
            {
                foreach( char c in phone.ToCharArray())
                {
                    bool b = IsNumber(c) || c == '-';
                    if(b == false)
                    {
                        Console.WriteLine("in phone number " + phone + ". There is a non-number/non-dash");
                        return false;
                    }
                }

                string[] nums = phone.Split('-');
                if(nums.Length == 3)
                {
                    string areaCode = nums[0];
                    bool areaGood = lengthFallsInRange(3, 3, areaCode);

                    string pre = nums[1];
                    bool preGood = lengthFallsInRange(3, 3, pre);

                    string post = nums[2];
                    bool postGood = lengthFallsInRange(4, 4, post);

                    if(areaGood && preGood && postGood)
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("Your phone number: " + phone + " does not contain 2 dashes");
                }
            }
            else if (phone.Contains('-') == false)
            {
                //1119994444
                if (phone.Length != 10)
                {
                    Console.WriteLine("Phone number " + phone + " in the nnnyyyxxxx format is too long or too short at " + phone.Length + " characters");
                    return false;
                }

                return true;
            }
            else
            {
                Console.WriteLine("The input number does not contain dashes");
            }
            return false;
        }

        static bool ValidateDate(string date)
        {
            DateTime temp;
            if (DateTime.TryParse(date, out temp))
            {
                Console.WriteLine(temp + " is valid");
                return true;
            }
            else
            {
                Console.WriteLine(temp + " is not valid");
                return false;
            }
        }
    }
}
