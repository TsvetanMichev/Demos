using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MathFiguresFull
{
    internal abstract class Shape : IPrint
    {
        protected string name;
        protected int sideA;
        protected int sideB;

        public abstract int Perimeter();
        public abstract int Area();
        public abstract void Print();
    }
}
