using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven
{
    class Cake
    {
        private String flavor;
        private String icing;
        private int bakingTemp;
        private bool done = false;

        public Cake(string flavor, string icing, int bakingTemp)
        {
            this.flavor = flavor;
            this.icing = icing;
            this.bakingTemp = bakingTemp;
        }

        public String GetFlavor()
        {
            return flavor;
        }

        public String GetIcing()
        {
            return icing;
        }

        public int GetBakingTemp()
        {
            return bakingTemp;
        }

        public bool GetDone()
        {
            return done; 
        }

        public void SetDone(bool done)
        {
            this.done = done;
        }
    }
}
