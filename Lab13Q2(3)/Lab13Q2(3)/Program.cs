using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Q2_3_
{
    class Program
    {
        static double Vol, TSA;
        static void Main(string[] args)
        {
            Console.Write("Enter Radius of cylinder: ");
            double radius = Double.Parse(Console.ReadLine());
            Console.Write("Enter Height of cylinder: ");
            double height = Double.Parse(Console.ReadLine());
            
            calculate(radius, height);

            Console.Write($"The volume of the cylinder is: {Vol.ToString("N2")} " +
                $"\nThe Total Surface Area of the cyliner is: {TSA.ToString("N2")}");
            Console.ReadKey();
        }

        static void calculate(double radius, double height)
        {
            Vol = (Math.PI * (Math.Pow(radius, 2)) * height);
            TSA = 2 * (Math.PI * radius * height) + 2 * Math.PI * Math.Pow(radius, 2);
        }
    }
}
