using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLine
{
    class TimeLine
    {
        List<HistoricalEvent> events = new List<HistoricalEvent>();

        public void Add(HistoricalEvent h)
        {
            events.Add(h);
        }

        public void PrintTimeLine()
        {
            foreach(HistoricalEvent e in events)
            {
                e.PrintDetails();
            }
        }
    }
}
