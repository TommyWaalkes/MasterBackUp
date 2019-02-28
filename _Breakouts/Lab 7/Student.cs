using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Student
    {
        private string homeTown;
        private string favoriteFood;
        private string name;

        public Student(string n, string ht, string ff )
        {
            name = n;
            homeTown = ht;
            favoriteFood = ff;
        }

        public override string ToString()
        {
            string s = name + " " + homeTown + " " + favoriteFood;
            return s;
        }

    }
}
