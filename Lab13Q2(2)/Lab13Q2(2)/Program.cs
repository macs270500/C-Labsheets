using System;

namespace Lab13Q2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius of cylinder: ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("Enter Height of cylinder: ");
            double height = double.Parse(Console.ReadLine());
            double Vol = 0, TSA = 0;
            calculate(radius, height, ref Vol, ref TSA);

            Console.Write($"The volume of the cylinder is: {Vol.ToString("N2")} " +
                $"\nThe Total Surface Area of the cyliner is: {TSA.ToString("N2")}");
            Console.ReadKey();
        }

        static void calculate(double radius, double height, ref double Vol, ref double TSA)
        {
            Vol = (Math.PI * (Math.Pow(radius, 2)) * height);
            TSA = 2 * (Math.PI * radius * height) + 2 * Math.PI * Math.Pow(radius, 2);
        }
    }
}

