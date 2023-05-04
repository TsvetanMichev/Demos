using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFiguresFull
{
    internal class Rectangle : Shape
    {
        public Rectangle(string name, int sideA, int sideB)
        {
            this.name = name;
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override int Perimeter()
        {
            return 2*sideA + 2*sideB;
        }
        public override int Area()
        {
            return sideA * sideB;
        }
        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
