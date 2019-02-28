using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort c = new Cohort();
           Student s =  c.GetStudent(0);

            //string t = s + " ";
            //Console.WriteLine(true.ToString() + 1 + "Tommy");
        }
    }
}
