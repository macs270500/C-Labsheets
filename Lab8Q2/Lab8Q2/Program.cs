using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks for 5 students");
            for (int i = 1;i<=5;i++)
            {
                double total = 0;
                Console.WriteLine($"Student{i}");
                for (int c = 1;c<=3; c++)
                {
                    Console.Write($"Enter mark{c}: ");
                    double mark = Double.Parse(Console.ReadLine());
                    total += mark;
                }
                double average = total / 3;
                Console.WriteLine($"Total mark is {total} and average is {average}");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
