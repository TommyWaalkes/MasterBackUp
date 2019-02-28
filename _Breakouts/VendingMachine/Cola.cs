using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Cola
    {
        public string Name { get; set; }
        public double GramsOfSugar { get; set; }
        public double MgOfCaffeine { get; set; }
        public string Brand { get; set; }
        public double Cost { get; set; }
        public int Stock { get; set; }

        public Cola(string Name, double GramsOfSugar, double MgOfCaffeine, string Brand, int Cost, int Stock)
        {
            this.Name = Name;
            this.GramsOfSugar = GramsOfSugar;
            this.MgOfCaffeine = MgOfCaffeine;
            this.Brand = Brand;
            this.Cost = Cost;
            this.Stock = Stock;
        }
    }
}
