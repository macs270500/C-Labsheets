using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripDistance, kmPerLiterEstimate, avgCost, litersOfFuel, estimatedCost;
            Console.Write("Enter the trip distance in km:");
            tripDistance = Double.Parse(Console.ReadLine());
            Console.Write("Enter the kilometer per liter estimate:");
            kmPerLiterEstimate = Double.Parse(Console.ReadLine());
            Console.Write("Enter the average cost of fuel per liter:");
            avgCost = Double.Parse(Console.ReadLine());
            litersOfFuel = tripDistance / kmPerLiterEstimate;
            estimatedCost = litersOfFuel * avgCost;
            Console.WriteLine($"The amount of fuel needed is {litersOfFuel}. \nThe cost of the trip is {estimatedCost}.");
            Console.ReadKey();
        }
    }
}
