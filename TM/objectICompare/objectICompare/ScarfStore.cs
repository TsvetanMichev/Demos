using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectICompare
{
    internal class ScarfStore : IEnumerable<Scarf>
    {
        private List<Scarf> scarves;

        public ScarfStore(List<Scarf> scarves)
        {
            this.scarves = new List<Scarf>(scarves);
        }

        public IEnumerator<Scarf> GetEnumerator()
        {
            for (int i = 0; i < scarves.Count; i++)
            {
                yield return scarves[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
