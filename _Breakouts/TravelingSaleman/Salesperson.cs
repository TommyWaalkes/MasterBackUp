using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSaleman
{
    class Salesperson
    {
        private Map m;
        private City startPoint;
        private List<City> route = new List<City>();
        private bool excludePrev;
        private bool getClosest;
        private Random r = new Random();

        public City StartPoint { get { return startPoint; } }
        public List<City> Route { get { return route; } }

        public Salesperson(Map m, City startPoint, List<City> route, string nextMethod)
        {
            //Set the next method
            this.m = m;
            this.startPoint = startPoint;
            this.route = route;
            route.Add(startPoint);
        }

        public Salesperson(Map m)
        {
            //Pick the next method at Random
            this.m = m;
            startPoint = m.GetRandomCity();
            route.Add(startPoint);
            PickNext(r);
        }

        public Salesperson(Map m, string nextMethod)
        {
            this.m = m;
            startPoint = m.GetRandomCity();
            route.Add(startPoint);
            PickNext(nextMethod);
            
        }

        public void PickNext(Random r)
        {
            int pick = r.Next(10);
            if (pick > 5)
            {
                excludePrev = true;
            }
            else
            {
                excludePrev = false;
            }

            pick = r.Next(10);
            if (pick > 5)
            {
                getClosest = true;
            }
            else
            {
                getClosest = false;
            }
        }

        public void PickNext(string nextMethod)
        {
            switch (nextMethod)
            {
                case "random":
                    getClosest = false;
                    excludePrev = false;
                    break;
                case "closest":
                    getClosest = true;
                    excludePrev = false;
                    break;
                case "exclude":
                    getClosest = false;
                    excludePrev = true;
                    break;
                default:
                    PickNext(r);
                    break;
            }
        }

        public double CalcRouteDistance()
        {
            double total = 0;
            for (int i = 0; i < route.Count; i++)
            {
                City c1 = route[i];
                //Console.WriteLine(c1.Name);
                if (i < route.Count - 1)
                {
                    City c2 = route[i + 1];
                    total += c1.CalcDistanceTo(c2);
                }
            }

            return total;

        }

        public void NextCity()
        {
            City c;
            if (getClosest)
            {
                //Console.WriteLine("yo");
                c = m.GetClosestCity(route[route.Count -1], route);
               // Console.WriteLine(c.Name);
               
            }
            else if (excludePrev)
            {
                while (true)
                {
                    c = m.GetRandomCity();

                    if (!route.Contains(c))
                    {
                        //Console.WriteLine($"{name} has added {c.Name} to their route");
                        break;
                    }
                }
            }
            else
            {
                c = m.GetRandomCity();
            }

            route.Add(c);

        }

        public City GetClosestCity()
        {
            //City c = route[route.Count - 1];
            City current = route.Last();
            List<City> cities = m.Cities;
            //double dist = current.CalcDistanceTo(cities[0]);
            City closest = current;
            double dist = double.MaxValue;

            Console.WriteLine("Start Loop");
            for (int i = 0; i < cities.Count - 1; i++)
            {
                if (HasBeenToAllCities())
                {
                    break;
                }
                Console.WriteLine(i);
                City c2 = cities[i];
                
                
                
                    double dist2 = current.CalcDistanceTo(c2);

                    if (dist > dist2)
                    {
                        dist = dist2;
                        closest = c2;
                    }
                
            }

            return closest;
        }

        public bool HasBeenToAllCities()
        {
            List<string> names = m.GetCityNames();
            List<string> routeNames = new List<string>();

            foreach (City c in route)
            {
                routeNames.Add(c.Name);
            }
            foreach (string name in m.GetCityNames())
            {
                if (!routeNames.Contains(name))
                {
                    return false;
                }
            }
            return true;
        }

        public void FillInRoutePart(int steps)
        {
            int i = 0;
            while (i < steps)
            {
                if (HasBeenToAllCities())
                {
                    break;
                }
                NextCity();
                i++;
            }
        }

        public void FillInRouteWhole()
        {
            int i = 0;
            while (HasBeenToAllCities() == false)
            {
                //Console.WriteLine("hey");
                NextCity();
                i++;
            }
        }





    }
}
