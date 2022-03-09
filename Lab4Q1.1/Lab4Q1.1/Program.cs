using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles,kilometers;
            Console.WriteLine("Enter the number of miles to be converted");
            miles = Double.Parse(Console.ReadLine());
            kilometers = miles * 1.609;
            Console.WriteLine($"The distance in kilometers is {kilometers}");
            Console.ReadKey();
        }
    }
}
