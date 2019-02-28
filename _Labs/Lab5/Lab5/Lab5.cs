using System;

public class Lab5
{
    public static void Main()
    {
       
        Boolean run = true;
        Random rando = new Random();
        Random r = new Random();
        while (run == true)
        {
            //Console.WriteLine(rando.Next(1, 10));
            //Console.WriteLine(r.Next(1, 10));
            //Console.WriteLine();
            //Console.WriteLine(rando.Next(1, 10));
            //Console.WriteLine(r.Next(1, 10));

            Console.WriteLine("Please input a number of sides");
            int sides = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (run == true)
            {
                Console.WriteLine("Roll:");

               int roll1= Roll(rando, sides);
               int roll2 = Roll(rando, sides);
                Console.WriteLine(roll1);
                Console.WriteLine(roll2);
                
                Console.WriteLine();
                run = Continue();
            }
        }
    }

    public static Boolean Continue()
    {
        Boolean run;
        Console.WriteLine("Roll the dice? Y/N");
        String answer = Console.ReadLine();

        if ((answer == "Y") || (answer == "y"))
        {
            run = true;
        }
        else if ((answer == "N") || (answer == "n"))
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

    public static int Roll(Random rando, int sides)
    {
        int result = rando.Next(1, sides+1);
        return result;
    }
}