using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (smaller than or equal to 170) to calculate its factorial:");
            double num = double.Parse(Console.ReadLine());
            Console.Write($"{num}! = {num}");
            for(int i = 1; i <= num; i++)
            {
                Console.Write($" x {num - i}");
            }
            Console.Write($" = {Factorial(num)}");
            Console.ReadKey();
        }
        private static double Factorial(double num)
        {
            if(num==0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }

    }
}
