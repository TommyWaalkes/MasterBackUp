using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSaleman
{
    class Program
    {
        static void Main(string[] args)
        {
            int pop = 100;
            int cities = 20;
           
            SalesForce sf1 = new SalesForce(1, cities, pop, "exclude");
            SalesForce sf = new SalesForce(1, cities, pop, "closest");
            SalesForce sf2 = new SalesForce(1, cities, pop, "random");
            List<Salesperson> sp =  sf.RunFirstGeneration(pop);
            List<Salesperson> sp2 = sf1.RunFirstGeneration(pop);
            List<Salesperson> sp3 = sf2.RunFirstGeneration(pop);

            Console.Clear();
            sf.PrintReadOut(sp);
            sf1.PrintReadOut(sp2);
            sf2.PrintReadOut(sp3);

            Console.ReadLine();

        }
    }
}
