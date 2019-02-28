using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    //This class represents the blueprint for building us a car 
    class Car
    {
        //How do we implement Miles per gallon?

        //Note that 
        private string Name;
        //public string GetName { get { return Name; } }

        private int milesTraveled;

        private int gas;
     
        private const int gasMax = 14;
          
        //this is a special method called the constructor  
        //Whenever we want to build an object we call this method
        //The car constructor builds and then returns a car object
        public Car(String n, int miles)
        {
            Name = n;
            milesTraveled = miles;
            Refuel();
            Console.WriteLine(Name + " has been built!");
        }

        //Note that since we're in an object we will no longer need to use static
        //Static, generally, won't be used in objects. 
        //A static variable or method means it can be used WITHOUT making an object
        //Up until today, we haven't been writing our own objects, hence why we used static
        public void DriveMile()
        {
            if (gas > 0)
            {
                milesTraveled++;
                gas--;
                Console.WriteLine("You've driven " + milesTraveled +" miles");
                Console.WriteLine("You have " + gas + " gallons of gas left");
            }
            else
            {
                Console.WriteLine("You're out of gas!");
            }
        }

        public void Refuel()
        {
            gas = gasMax;
        }

        public void PrintFuel()
        {
            Console.WriteLine(Name + " has "+gas +" gallons of gas left");
        }

        public static void PrintCake()
        {
            Console.WriteLine("Cake");
        }

        public int GetGas()
        {
            return gas;
        }

        public void SetGas(int g)
        {
            gas = g;
        }

        
    }
}
