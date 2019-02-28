using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class NorthAmericaDB
    {
        public List<Country> Countries = new List<Country>();

        public NorthAmericaDB()
        {
            
            string[] USColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("USA", "English", "Hello world!", USColors));
            string[] MexicoColors = { "Red", "White", "Green" };
            Countries.Add(new Country("Mexico", "Spanish", "Hola Mundo!", MexicoColors));
            string[] CanadaColors = { "Red", "White" };
            Countries.Add(new Country("Canada","English and French", "Bonjour le Monde", CanadaColors));

        }
    }
}
