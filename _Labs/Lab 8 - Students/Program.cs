using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8___Students
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run == true)
            {
                Console.WriteLine("Hello! Please select a solution:");
                Console.WriteLine("1) Arrays");
                Console.WriteLine("2) Lists");
                Console.WriteLine("3) Objects");
                string input = Console.ReadLine();
                int pick = 0;
                if(int.TryParse(input, out pick))
                {
                    switch (pick)
                    {
                        case 1:
                            Array();
                            break;
                        case 2:
                            List();
                            break;
                        case 3:
                            Object();
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry that wasn't a valid option, let's try again.");
                }
            }
        }

        public static void Object()
        {
            //So once we know objects, I'll fill this in
            List<Student> students = new List<Student>();
            Student t = new Student("Tommy", "Buttered Chicken", "Raleigh");
            Student p = new Student("Phil", "Cow Boy Pasta", "Fredrick");
            Student j = new Student("Joey", "Marshmellows", "Fredrick");

            students.Add(t);
            students.Add(p);
            students.Add(j);

            Console.WriteLine("Please Pick an option");
            for(int i = 0; i < students.Count; i++)
            {
                Student s = students[i];
                Console.WriteLine(i +": " +s.GetName());
            }

            Console.WriteLine(students.Count + ": exit");

            string choice = Console.ReadLine();

            int pick = 0;

            bool goodInt = int.TryParse(choice, out pick);

            if (goodInt)
            {
                Student picked = students[pick];

                Console.WriteLine("Learn about " + picked.GetName());
                Console.WriteLine("1) favorite food");
                Console.WriteLine("2) home town");

                string input = Console.ReadLine();

                if(input == "1")
                {
                    Console.WriteLine(picked.GetName() + "'s favorite food is "+ picked.GetFood());
                }
                else if(input == "2")
                {
                    Console.WriteLine(picked.GetName() + "'s hometown is " + picked.GetHomeTown());
                }
            }
            Console.ReadLine();
            Console.Clear();


        }

        public static void List()
        {

            {
                Console.WriteLine("List Solution: ");
                List<string> names = new List<string> { "Tommy", "Joey", "Phil" };
                List<string> foods = new List<string> { "Buttered Chicken", "Mashmellows", "Cow boy pasta" };
                List<string> homeTowns = new List<string> { "Raleigh", "Fredrick", "Fredrick" };

                //You can also add someone like so 
                names.Add("Slim Shady");
                foods.Add("moms Spaghetti");
                homeTowns.Add("Detroit");

                bool run = true;

                while (run == true)
                {
                    Console.WriteLine("Which Student would you like to learn about: ");
                    for (int i = 0; i < names.Count; i++)
                    {
                        Console.WriteLine(i + ": " + names[i]);
                    }
                    Console.WriteLine(names.Count + ": exit");

                    string choice = Console.ReadLine();
                    int pick = 0;
                    if (int.TryParse(choice, out pick))
                    {
                        if (pick < names.Count)
                        {
                            Console.WriteLine("What would you like to learn about " + names[pick] + "?");
                            Console.WriteLine("1) their Favorite Food");
                            Console.WriteLine("2) their hometown");
                            Console.WriteLine();
                            string s = Console.ReadLine();
                            s = s.Trim();
                            if (s == "1")
                            {
                                Console.WriteLine(names[pick] + "s favorite food is " + foods[pick]);
                            }
                            else if (s == "2")
                            {
                                Console.WriteLine(names[pick] + "s home town is " + homeTowns[pick]);
                            }
                        }
                        else if (pick == names.Count)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid choice, let's try again");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public static void Array()
        {
            Console.WriteLine("Array Solution: ");
            String[] names = { "Tommy", "Joey", "Phil" };
            String[] foods = { "Buttered Chicken", "Mashmellows", "Cow boy pasta" };
            string[] homeTowns = { "Raleigh", "Fredrick", "Fredrick" };

            bool run = true;

            while(run == true)
            {
                Console.WriteLine("Which Student would you like to learn about: ");
                for(int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(i + ": " + names[i]);
                }
                Console.WriteLine(names.Length +": exit");

                string choice = Console.ReadLine();
                int pick = 0;
                if (int.TryParse(choice, out pick))
                {
                    if (pick < names.Length)
                    {
                        Console.WriteLine("What would you like to learn about " + names[pick] + "?");
                        Console.WriteLine("1) their Favorite Food");
                        Console.WriteLine("2) their hometown");
                        Console.WriteLine();
                        string s = Console.ReadLine();
                        s = s.Trim();
                        if (s == "1")
                        {
                            Console.WriteLine(names[pick] + "s favorite food is " + foods[pick]);
                        }
                        else if (s == "2")
                        {
                            Console.WriteLine(names[pick] + "s home town is " + homeTowns[pick]);
                        }
                    }
                    else if(pick == names.Length)
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid choice, let's try again");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
