using System;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the letter grade converter!");
            Console.WriteLine("Please input a number between 1 and 100");
                            
            int gradeNum = int.Parse(Console.ReadLine());
            string letterGrade = "I'm sorry that input was invalid"; ;
            if (gradeNum > 100)
            {
                letterGrade = "Your input was over 100, please try again";
            }
            else if ((gradeNum>=88)&&(gradeNum<=100))
            {
                letterGrade = "A";
            }
            else if(gradeNum >=80 )
            {
                letterGrade = "B";
            }
            else if (gradeNum >= 67)
            {
                letterGrade = "C";
            }
            else if (gradeNum>=60)
            {
                letterGrade = "D";
            }
            else if (gradeNum>=0)
            {
                letterGrade = "F";
            }
            else if (gradeNum<0)
            {
                letterGrade = "Your input was less than 0, please try again";
            }

            Console.WriteLine(letterGrade);
        }
    }
}