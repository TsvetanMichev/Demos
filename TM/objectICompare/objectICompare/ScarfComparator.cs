using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectICompare
{
    internal class ScarfComparator : IComparer<Scarf>
    {
        public int Compare(Scarf? x, Scarf? y)
        {
            return x.Material.CompareTo(y.Material);
        }
    }
}
