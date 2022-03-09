using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = 1; k <= j; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
    }
}
