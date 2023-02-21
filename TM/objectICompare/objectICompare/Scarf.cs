using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectICompare 
{
    internal class Scarf : IComparable<Scarf>
    {
        private string brand;
        private string material;
        private int price;

        public Scarf(string brand, string material, int price)
        {
            this.brand = brand;
            this.material = material;
            this.price = price;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int CompareTo(Scarf other)
        {
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this.Brand, this.Material, this.Price);
        }
    }
}
