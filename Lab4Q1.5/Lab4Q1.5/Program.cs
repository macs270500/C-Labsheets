using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, sum, average;
            sum = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("enter a number", i);
                num = Double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"The sum of the numbers is {sum}");
            average = sum / 4;
            Console.WriteLine($"The average of the numbers is {average}");
            Console.ReadKey();
        }
    }
}
