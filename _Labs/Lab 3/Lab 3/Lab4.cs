using System;

public class Lab4
{
    public static void Main()
    {
        Boolean run = true;
        while (run == true)
        {
            Console.WriteLine("Please Enter an Integer");
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine("Number--Square--Cube");

            for (int i = 1; i <= num; i++)
            {
                Multiply(i);

               
            }

            run = Continue();
        }
    }

   

    public static long Square(long num)
    {
        long square = num * num;
        return square;
    }

    public static long Cube(long num)
    {
       
        long cube = num * num * num;
        return cube;
    }

    public static void Multiply(long num)
    {
        long square = Square(num);
        long cube = Cube(num);

        Console.WriteLine(num + "  --  " + square + "  --  " + cube);
    }

    public static Boolean Continue()
    {
        Boolean run;
        Console.WriteLine("Continue? Y/N");
        String answer = Console.ReadLine();
        answer = answer.ToLower();

        if (answer == "y")
        {
             run = true;
        } 
        else if (answer == "n")
        {
            run = false;
            Console.WriteLine("Good Bye!");
        }
        else
        {
            Console.WriteLine("I'm sorry I don't understand. Let's try again");
            run = Continue();
        }
        return run;
    }
}

