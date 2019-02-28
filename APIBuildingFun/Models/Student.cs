using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBuildingFun.Models
{
    public class Student
    {
        public string Name { get;set;}
        public int Age { get; set; }
        public string FavoriteClass { get; set; }

        public Student()
        {

        }

        public Student(string Name, int Age, string FavoriteClass)
        {
            this.Name = Name;
            this.Age = Age;
            this.FavoriteClass = FavoriteClass;
        }
    }
}