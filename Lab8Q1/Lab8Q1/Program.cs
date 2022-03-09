
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number and I'll write a sequence of numbers till that number: ");
            double num = Double.Parse(Console.ReadLine());
            for (int i = 1; i<= num; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }
    }
}
