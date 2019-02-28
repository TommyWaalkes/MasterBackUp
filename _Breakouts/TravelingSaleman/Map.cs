using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSaleman
{
    class Map
    {
        private Dictionary<City, Path> distTable = new Dictionary<City, Path>();
        private List<City> cities = new List<City>();
        private List<Path> paths = new List<Path>();
        public int Length { get { return cities.Count; } }
        private Random r = new Random();

        public List<City> Cities { get { return cities; } }

        public Map(int maxCities)
        {
            for (int i = 0; i < maxCities; i++)
            {
                City ci = new City(i * i, i * i, i + "");
                Add(ci);
            }

            FillInDistTable();
        }

        public void Add(City c)
        {
            cities.Add(c);
        }

        public City GetCity(int index)
        {
            return cities[index];
        }

        public City GetRandomCity()
        {
            
            int index = r.Next(0, Length);

            return GetCity(index);
        }

        public void FillInDistTable()
        {
            paths = new List<Path>();
            foreach(City start in cities)
            {
                
                foreach(City end in cities)
                {
                    Path p = new Path(start, end);
                    paths.Add(p);
                    //Console.WriteLine(start.Name);
                }
            }
        }

        public City GetClosestCity(City input, List<City> route)
        {
            List<double> distances = new List<double>();
            List<Path> possiblePaths = new List<Path>();
            
            
            //var possiblePaths = paths.Where(p => p.Start.Equals(input));
           // int i = possiblePaths.Count();
           // Console.WriteLine(i);
            foreach (Path p in paths)
            {
                City pp = p.Start;
                //Console.WriteLine(pp.Name);
                if (!route.Contains(pp))
                {
                    if (pp.Equals(input))
                    {
                        possiblePaths.Add(p);
                    }
                }
                //Console.WriteLine(p.Dist);
               // Console.WriteLine(p.Dist);
            }

           // Console.ReadLine();

            Path shortest = new Path(GetRandomCity(), GetRandomCity());

            while(shortest.Dist == 0)
            {
                shortest = new Path(GetRandomCity(), GetRandomCity());
            }

            foreach(Path p in possiblePaths)
            {
                if(p.Dist > 0 && p.Dist < shortest.Dist)
                {
                    shortest = p;
                }
            }

            return shortest.End;

           
            //double dist = double.MaxValue;
            //int cityIndex = -1;
            //for(int i = 0; i < cities.Count; i++)
            //{
            //    City c = cities[i];
            //    double d = input.CalcDistanceTo(c);
            //    if(d > 0 && d < dist)
            //    {
            //        dist = d;
            //        distances.Add(d);
            //        cityIndex = i;
            //    }
            //}

            //distances.Sort();

            //return cities[cityIndex];
        }

        public List<string> GetCityNames()
        {
            List<string> names = new List<string>();
            foreach(City c in cities)
            {
                names.Add(c.Name);
            }

            return names;
        }
    }
}
