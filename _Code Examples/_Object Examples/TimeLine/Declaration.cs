using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLine
{
    class Declaration : HistoricalEvent
    {
        public Declaration()
            :base(1776, "Signing of the Declaration of independance", "America is founded", true)
        {

        }

        public void PrintYear()
        {
            Console.WriteLine(year);
        }

    }
}
