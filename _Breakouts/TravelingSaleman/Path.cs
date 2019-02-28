using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSaleman
{
    class Path
    {
        private City start;
        private City end;
        public double Dist { get { return start.CalcDistanceTo(end); } }
        public City Start { get { return start; } }
        public City End { get { return end; } }

        public Path(City start, City end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
