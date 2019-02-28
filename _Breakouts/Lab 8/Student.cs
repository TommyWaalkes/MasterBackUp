using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Student
    {
        public string name;
        public string favoriteFood;
        public string homeTown;

        public Student(string name, string ff, string ht)
        {
            this.name = name;
            favoriteFood = ff;
            homeTown = ht;
        }

        public void PrintInfo()
        {
            string message = "Student Info";
            Console.WriteLine(message);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Home Town: "+homeTown);
            Console.WriteLine("Favorite Food: "+ favoriteFood);
        }
    }
}
