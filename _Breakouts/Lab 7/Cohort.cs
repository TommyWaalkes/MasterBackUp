using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Cohort
    {
        private List<Student> Students = new List<Student>();

        public Cohort()
        {
            Student s = new Student("Tammy", "GR", "Sushi");
            Students.Add(s);
            Students.Add(new Student("Phil", "Duck NC", "Chicken"));
        }

        public Student GetStudent(int i)
        {
            Student s = Students[i];
            Console.WriteLine(s);
            return s; 
        }
    }
}
