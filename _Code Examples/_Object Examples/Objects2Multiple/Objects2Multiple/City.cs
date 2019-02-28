using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects2Multiple
{
    class City
    {
        private string name;
        private int houses;
        private int wood;
        public int water { get; set; }
        public int food { get; set; }
        private int day;
        private List<Person> villagers;
        private List<WaterSource> waterSources;

        public City(int pop)
        {
            Console.WriteLine("Name your city:");
            name = Console.ReadLine();
            water = 10;
            food = 10;
            houses = pop;
            wood = 0;
            day = 0;
            villagers = new List<Person>();
            waterSources = new List<WaterSource>();
            for (int i = 0; i < pop; i++)
            {
                villagers.Add(new Person(this));
            }
            Console.WriteLine("Welcome to "+name+" with " + villagers.Count + " Population");
            Console.WriteLine("Goal is to keep your population alive and get to 10 population.");

            turn();
        }
        public int GetPop()
        {
            return villagers.Count; 
        }

        public void IncreasePop(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                villagers.Add(new Person(this));
            }
        }

        public void IncreaseWood()
        {
            wood++;
        }
        public void IncreaseWood(int amount)
        {
            wood += amount;
        }
        
        public void BuildHouse()
        {
            if (wood >= 5)
            {
                wood -= 5;
                houses++;
                Console.WriteLine("You Built a house!");
            }
            else
            {
                Console.WriteLine("You didn't build a house! You need at least 5 wood.");
            }
        }

        public void BuildWell()
        {
            if (wood >= 6)
            {
                wood -= 6;
                waterSources.Add(new WaterSource("Well", 1));
                Console.WriteLine("You Built a well!");
            }
            else
            {
                Console.WriteLine("You didn't build a well! You need at least 6 wood.");
            }
        }

        public void killPerson(Person p)
        {
            villagers.Remove(p);
        }

        public int calculateWaterPerTurn()
        {
            int total = 0;
            foreach(WaterSource w in waterSources)
            {
                Console.WriteLine("Your " + w.name +" produces "+w.supply +" gallons of water per turn");
                total += w.supply;
            }
            Console.WriteLine("Your total water per turn is "+total);
            return total;
        }

        public void printWater()
        {
            Console.WriteLine(name + " has " + water+ " gallons of water");
        }

        public void printFood()
        {
            Console.WriteLine(name + " has " + food + " pounds of food");
        }

        public void printPop()
        {
            Console.WriteLine("Your city has " + villagers.Count + " Population");
        }

        public void printWood()
        {
            Console.WriteLine("You have "+wood+" wood");
        }

        public void printHouses()
        {
            Console.WriteLine("Your city has "+houses+" houses");
        }

        public void printStats()
        {
            printPop();
            printWater();
            printFood();
            printWood();
            printHouses();
            Pause();
        }

        public void Pause()
        {
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        public void turn()
        {
            day++;
            Console.WriteLine("__________________________________");
            Console.WriteLine("It's the start of day "+ day+"!");
            water += calculateWaterPerTurn();
            printStats();

            if (GetPop()>0)
            {
                if (houses > GetPop())
                {
                    int diff = houses - GetPop();
                    for(int i = 0; i < diff; i++)
                    {
                        Console.WriteLine("A new person has moved into your village!");
                        villagers.Add(new Person(this));
                    }
                }
                List<Person> deadVillagers = new List<Person>();
                for(int i = 0; i < villagers.Count; i++)
                {
                    Person p = villagers[i];
                    p.Work();
                }
                   

                
                //Eating loop
                foreach(Person p in villagers)
                {
                    if (p.Drink() == false|| p.Eat() == false)
                    {
                        //If they don't drink they die 
                        //We build up a seperate list since you can't modify 
                        //a list in a foreach loop
                        deadVillagers.Add(p);
                    }
                }
                printWater();
                printFood();
                Pause();
                foreach(Person p in deadVillagers)
                {
                    //Remove dead people from the list 
                    //The list.remove() method searches by item and removes any matches
                    villagers.Remove(p);
                }
                if (villagers.Count > 0)
                {
                    turn();
                }
                else
                {
                    Lose();
                }
                
            }
            else
            {
                Lose();
            }
        }

        public void Lose()
        {
            Console.WriteLine();
            Console.WriteLine("Everyone in " + name + " is dead, sorry!");
            Console.WriteLine("You made it to day " + day);
        }
    }
}
