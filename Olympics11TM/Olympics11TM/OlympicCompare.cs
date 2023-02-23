using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicsComparators11TM;

namespace OlympicsComparators11TM
{
    internal class OlympicCompare : IComparer<Olympic>
    {
        public int Compare(Olympic? x, Olympic? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
