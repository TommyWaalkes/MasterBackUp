using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please Enter a Integer Between 1 and 1000, Inclusive");

        int num = int.Parse(Console.ReadLine());

        if (1 <= num && num <= 1000)
        {
            int total = 1;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Factorial of: " + i);
                total *=i;
                //total = i * total;
                Console.WriteLine(total);
               
            }
            Console.WriteLine("The Factorial of " + num + " is " + total);
        }
        else
        {
            Console.WriteLine("The input integer was not between 1 and 1000");
        }

       

        
    }
}