using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double depth, celcius, farenheit;
            Console.WriteLine("Enter the depth of the location where the temperature is to be calculated");
            depth = Double.Parse(Console.ReadLine());
            celcius = 10 * depth + 20;
            farenheit = 1.8 * celcius + 32;
            Console.WriteLine($"Temperature of the earth at {depth}m \n is {celcius}*C and {farenheit}*F");
            Console.ReadKey();
        }
    }
}
