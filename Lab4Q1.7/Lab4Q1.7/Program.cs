using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, gradient, distance;
            Console.WriteLine("Input coordinates x1 & y1");
            Console.Write("x1:");
            x1 = Double.Parse(Console.ReadLine());
            Console.Write("y1:");
            y1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input coordinates x2 & y2");
            Console.Write("x2:");
            x2 = Double.Parse(Console.ReadLine());
            Console.Write("y2:");
            y2 = Double.Parse(Console.ReadLine());
            gradient = (y2 - y1) / (x2 - x1);
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"The gradient is {gradient} & the distance between them is {distance}");
            Console.ReadKey();
        }
    }
}
