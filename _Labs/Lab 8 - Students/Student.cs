using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8___Students
{
    class Student
    {
        private string name;
        private string favoriteFood;
        private string homeTown;

        public Student(string name, string favoriteFood, string homeTown)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
            this.homeTown = homeTown;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetFood()
        {
            return favoriteFood;
        }

        public void SetFood(string favoriteFood)
        {
            this.favoriteFood = favoriteFood;
        }

        public string GetHomeTown()
        {
            return homeTown;
        }

        public void SetHomeTown(string homeTown)
        {
            this.homeTown = homeTown;
        }
    }
}
