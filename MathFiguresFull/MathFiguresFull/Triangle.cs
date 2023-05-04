using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFiguresFull
{
    internal class Triangle : Shape
    {
        private int sideC;
        public Triangle(string name, int sideA, int sideB, int sideC)
        {
            this.name = name;
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override int Perimeter()
        {
            return sideA + sideB + sideC;
        }
        public override int Area()
        {
            return sideA * sideB / 2;
        }
        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
