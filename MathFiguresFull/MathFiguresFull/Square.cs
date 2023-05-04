using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFiguresFull
{
    internal class Square : Shape/*, IComparable<Square>*/
    {
        public Square(string name, int sideA) 
        {
            this.name = name;
            this.sideA = sideA;
        }

        public override int Perimeter()
        {
            return 4*sideA;
        }
        public override int Area()
        {
            return sideA * sideB;
        }
        public override void Print()
        {
            throw new NotImplementedException();
        }

        //TODO: finish comparare
        //public int CompareTo(Square other)
        //{
        //    return ;
        //}
    }
}
