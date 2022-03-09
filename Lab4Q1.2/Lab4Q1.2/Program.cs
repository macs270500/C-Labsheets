using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, radius, area;
            pi = 3.14159;
            Console.WriteLine("Enter the radius of the circle");
            radius = Double.Parse(Console.ReadLine());
            area = pi * radius * radius;
            Console.WriteLine($"The area of the circle is {area}");
            Console.ReadKey();
        }
    }
}
