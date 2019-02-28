using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab8UserRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student One = new Student("Katie", "Grand Rapids", "Indian Cuisine");

            Student Two = new Student("Andrew", "Grand Haven", "Chicken Wings");

            Student Three = new Student("Chuck", "Ripon", "Almonds");

            Student Four = new Student("Jon", "Alger", "Tres Leche");

            Student Five = new Student("Tommy", "Raleigh, NC", "Buttered Chicken");

            Student Six = new Student("Jeremy", "Milwaukee", "Peanut Butter");

            Student Seven = new Student("Joseph", "Grand Rapids", "Burritos");

            Student Eight = new Student("Kelsey", "Grand Rapids", "Grit");

            Student Nine = new Student("Justin", "Wyoming", "Burgers");

            Student Ten = new Student("Sean", "Grand Rapids", "BBQ");


            students.Add(One);
            students.Add(Two);
            students.Add(Three);
            students.Add(Four);
            students.Add(Five);
            students.Add(Six);
            students.Add(Seven);
            students.Add(Eight);
            students.Add(Nine);
            students.Add(Ten);

            foreach(Student s in students)
            {
                Console.WriteLine(s);
            }



        }
    }
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentTown { get; set; }
        public string StudentFood { get; set; }

        public Student(string Studentname, string Studenttown, string Studentfood)
        {
            Studentname = StudentName;
            Studenttown = StudentTown;
            Studentfood = StudentFood;
        }
        
    }

}