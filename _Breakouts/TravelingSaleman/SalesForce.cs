using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSaleman
{
    class SalesForce
    {
        private Map m;
        private List<Salesperson> sp = new List<Salesperson>();
        private int maxGens = 0;
        private int maxCities = 0;
        private int parentsPerGen = 0;
        private string nextMethod = "def";
        private Random r = new Random();

        public SalesForce(int maxGens, int maxCities, int parentsPerGen, string nextMethod)
        {
            this.maxGens = maxGens;
            this.maxCities = maxCities;
            this.parentsPerGen = parentsPerGen;
            this.nextMethod = nextMethod;
            this.m = new Map(maxCities);
        }

        public SalesForce()
        {      
            Console.WriteLine("Please input the number of generations you want the simulator to run");
            string input = Console.ReadLine();

            while (!int.TryParse(input, out maxGens))
            {
                Console.WriteLine("Okay let's that again...");
                Console.WriteLine("Please input the number of generations you want the simulator to run");
                input = Console.ReadLine();
            }
            Console.WriteLine("Please input the number of cities you want to include along the route.");

            input = Console.ReadLine();
            while (!int.TryParse(input, out maxCities))
            {
                Console.WriteLine("Okay let's that again...");
                Console.WriteLine("Please input the number of cities you want to include along the route.");
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (!int.TryParse(input, out parentsPerGen))
            {
                Console.WriteLine("Okay let's that again...");
                Console.WriteLine("Please input how many parents you want per generation.");
                input = Console.ReadLine();
            }

            this.m = new Map(maxCities);
        }

        public List<Salesperson> RunFirstGeneration(int population)
        {
            int i = 0;
            List<Salesperson> salesForce = new List<Salesperson>();
            while (i < population)
            {
                Console.Clear();
                Console.WriteLine("Processing Sales Person "+i);
                Salesperson s = new Salesperson(m, nextMethod);
                s.FillInRouteWhole();
                salesForce.Add(s);
                i++;
            }
            List<Salesperson> nextGenParents = GetBestDistances(salesForce, parentsPerGen);
            return RunGeneration(population, nextGenParents, 0);
        }

        public List<Salesperson> RunGeneration(int population, List<Salesperson> nextGenParents, int currentGen)
        {
            Console.WriteLine("Current Gen "+ currentGen);
            bool done = IsDone(nextGenParents);


            if (currentGen < maxGens && done == false)
            {

                //int childrenPerParent = population / nextGenParents.Count;
                List<Salesperson> children = new List<Salesperson>();
                foreach (Salesperson s in nextGenParents)
                {
                    //for (int i = 0; i < childrenPerParent; i++)
                    //{
                    //    Salesperson sp = new Salesperson(m, s.StartPoint, s.Route);
                    //    sp.FillInRoute(1);
                    //    children.Add(sp);
                    //}
                   // s.FillInRouteWhole();
                }

                List<Salesperson> best = GetBestDistances(nextGenParents, parentsPerGen);
                currentGen++;
                return RunGeneration(population, best, currentGen);
            }
            else
            {
                Console.WriteLine("We're done!");
                //PrintReadOut(nextGenParents);
                return nextGenParents;
                
            }
        }

        public bool IsDone(List<Salesperson> gen)
        {
            foreach(Salesperson s in gen)
            {
                if (!s.HasBeenToAllCities())
                {
                    return false;
                }
            }
            return true;
        }

        public List<Salesperson> GetBestDistances(List<Salesperson>salesForce, int parents)
        {
            List<Salesperson> ranked = salesForce.OrderBy(o => o.CalcRouteDistance()).ToList();
            List<Salesperson> output = new List<Salesperson>();

            salesForce.GetRange(0, 20);
            for (int j = 0; j < parents && j < ranked.Count; j++)
            {
                output.Add(ranked[j]);
            }

            return output;
        }

        public double GetGenAverage(List<Salesperson> gen)
        {
            double total = 0;
            foreach(Salesperson sp in gen)
            {
                total += sp.CalcRouteDistance();
            }

            return total / gen.Count;
        }

        public double GetGenMedian(List<Salesperson> gen)
        {
            if(gen.Count % 2 == 0)
            {
                int start = gen.Count / 2;
                int end = (gen.Count / 2) + 1;
                double d = gen[start].CalcRouteDistance();
                double e = gen[end].CalcRouteDistance();
                return (e + d) / 2;
            }
            else
            {
                int start = gen.Count / 2;
                start++;
                return gen[start].CalcRouteDistance();
            }
        }

        public void PrintReadOut(List<Salesperson> gen)
        {
            Salesperson best = gen.OrderBy(o => o.CalcRouteDistance()).ToList()[0];
            Console.WriteLine("Method used: " + nextMethod);
            Console.WriteLine("Best: " + best.CalcRouteDistance());
            Console.WriteLine("Best Completed Full Route: " + best.HasBeenToAllCities());
            Console.WriteLine();
            Console.WriteLine("Group Stats");
            Console.WriteLine("Average: " + GetGenAverage(gen));
            Console.WriteLine("Median: " + GetGenMedian(gen));
            Console.WriteLine("Whole group completed Route: " + IsDone(gen));
           // Console.WriteLine("Min: "+ gen.Min());

            Console.WriteLine();
            Console.ReadLine();
        }

        public void PrintGeneration(List<Salesperson> gen)
        {
            for(int i = 0; i < gen.Count; i++)
            {
                Console.WriteLine();
                Salesperson sp = gen[i];
                Console.WriteLine($"Sales Person: {i}");
                Console.WriteLine("Starting City: "+sp.StartPoint.Name);
                Console.WriteLine("Route:");
                List<City> r = sp.Route;
                Console.WriteLine(sp.Route.Count);
                for (int j = 0; j < sp.Route.Count; j++)
                {
                    Console.WriteLine(r[j].Name);
                }
                Console.WriteLine("Total Distance: " + sp.CalcRouteDistance());
                Console.WriteLine("Has Completed Route: "+ sp.HasBeenToAllCities());
            }
        }
    }
}
