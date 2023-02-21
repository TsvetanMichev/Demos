using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectICompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scarf scarfOne = new Scarf("LV", "cotton", 9);
            Scarf scarfTwo = new Scarf("KK", "silk", 23);
            Scarf scarfThree = new Scarf("Spreme", "plastic", 15);
            List<Scarf> scarfList = new List<Scarf>()
            {
                scarfOne,
                scarfTwo,
                scarfThree
            };
            scarfList.Sort();
            Console.WriteLine(string.Join("; ",scarfList));

            //var comparator = new ScarfComparator();
            //scarfList.Sort(comparator);

            //scarfList.ForEach(x => Console.WriteLine(x.Material)); //print 1

            //Console.WriteLine(string.Join("; ", scarfList.Select(x => x.Material))); //print 2

            //Console.WriteLine(string.Join("; ", scarfList)); //print 3
        }
    }
}

