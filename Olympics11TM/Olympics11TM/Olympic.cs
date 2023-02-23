using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicsComparators11TM
{
    public class Olympic : IComparable<Olympic>, IPrint
    {
        private string name;
        private int points;

        public Olympic(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Points
		{
			get { return points; }
			set { points = value; }
		}

        public int CompareTo(Olympic? other)
        {
            return Points.CompareTo(other.Points); 
        }

        public void Print()
        {
            Console.WriteLine($"{name} - {points}");
        }
    }
}
