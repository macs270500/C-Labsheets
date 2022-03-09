using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1._4
{
    class Program
    {
        static void Main(string[] args)
        { double pi, radius, length, areaOfCircle,volOfCylinder, TSA;
            pi = 3.14159;
            Console.Write("Enter radius of cylinder:");
            radius = Double.Parse(Console.ReadLine());
            Console.Write("Enter length of cylinder:");
            length = Double.Parse(Console.ReadLine());
            areaOfCircle = pi * radius * radius;
            volOfCylinder = areaOfCircle * length;
            TSA = (2 * areaOfCircle) + (2 * pi * radius * length);
            Console.WriteLine($"The total surface area of the cylinder is {TSA} \n & the volume of the cylinder is {volOfCylinder}");
            Console.ReadKey();
        }
    }
}
