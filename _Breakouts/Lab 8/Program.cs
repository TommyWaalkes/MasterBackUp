using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Tommy", "Chicken Curry", "Raleigh NC");
            Student s2 = new Student("Laura", "Bibimbap", "The breaking bad town");
            Student s3 = new Student("Kendra", "Veggie Burger and Fries", "Oak Park Michigan");

            List<Student> students = new List<Student>() {s2, s3};
           
            students.Add(s);
            students.Add(s2);
            students.Add(s3);

            students.Add(new Student("Coleslaw Kenny", "Peach Cobbler", "Heart the of Texas"));

            Console.WriteLine("Please input a number from 0 to " + (students.Count - 1));
            string input = Console.ReadLine();
            int choice = int.Parse(input);

            Student output = students[choice];
            output.PrintInfo();

        }
    }
}
