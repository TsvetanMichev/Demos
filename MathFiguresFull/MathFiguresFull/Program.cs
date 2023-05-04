using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFiguresFull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("Number of shapes being entered?");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Which shape will you enter? (Square/Rectangle/Triangle) ");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "square":
                        Console.WriteLine("Enter name and side: ");
                        var data1 = Console.ReadLine().Split();
                        Shape shSq = new Square(data1[0], int.Parse(data1[1]));
                        break;

                    case "rectangle":
                        Console.WriteLine("Enter name and sides: ");
                        var data2 = Console.ReadLine().Split();
                        Shape shRc = new Rectangle(data2[0], int.Parse(data2[1]), int.Parse(data2[2]));
                        break;

                    case "triangle":
                        Console.WriteLine("Enter name and sides: ");
                        var data3 = Console.ReadLine().Split();
                        Shape shTr = new Triangle(data3[0], int.Parse(data3[1]), int.Parse(data3[2]), int.Parse(data3[3]));
                        break;
                }
            }
            //TODO: print list
        }
    }
}
