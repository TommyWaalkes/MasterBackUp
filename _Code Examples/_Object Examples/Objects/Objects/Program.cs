using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Objects
{
    class Program
    {
        //What this example will teach you: 
        //1) Constructors 
        //2) Instance Variable/Properties
        //3) Public vs. Private
        //4) Object Methods 

        //We're going to start jumping around to different files and places in our code 
        //But! The main method is still always the manager for the rest of our code 
        //Even in a 5000 file project it's the first method to be run
        //Also! There can only be one main method. Think of it as your front door.
        //It's like highlander: there can only be one
        static void Main(string[] args)
        {
            //Remember class = blueprint, instance/object = finished product
            //This is how we use the constructor to make an instance           
            Car t = new Car("Model T", 0 );

            
            //DriveMile();
            t.SetGas(20);
            
            Console.WriteLine();
            t.PrintFuel();
            t.DriveMile();
            t.DriveMile();
            t.DriveMile();
            t.PrintFuel();

            //This line is complaining, why is that? 
            Car c = new Car();
            //How do we drive 20 miles? Using OOP
            //C.drive() calls the method on that instance of the object
            c.DriveMile();
            Console.WriteLine();
            c.PrintFuel();

            List<Car> cars = new List<Car>();
            cars.Add(t);
            cars.Add(c);
            cars.Add(new Car("Toyota Camry", 10));

   
            Car k = cars[2];
            k.PrintFuel();

            Student s = new Student("Michelle", "Raleigh", "Chicken");

        }

        public static void Meow()
        {
            Console.WriteLine("Meow");
        }
    }
}
