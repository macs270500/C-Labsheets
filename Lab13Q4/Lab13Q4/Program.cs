using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the sphere: ");
            double radius = Double.Parse(Console.ReadLine());
            double volume = SphereVolume(radius);
            Console.WriteLine($"The volume of the sphere is {volume.ToString("N2")}");
            Console.ReadKey();
        }
        static double SphereVolume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
}
