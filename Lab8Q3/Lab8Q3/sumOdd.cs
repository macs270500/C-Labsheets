using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Q3
{
    class sumOdd
    {   public static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int count = 1, total = 0, oddpos = 1;

            if (num == 1)
            {
                total = 1;
            }
            else while (count <= num)
                {
                    total += oddpos;
                    oddpos += 2;
                    count++;
                }
            Console.WriteLine($"The sum of the first {num} odd numbers are {total}");
            Console.WriteLine("Press Enter to access main menu");
            Console.ReadKey();
        }
    }
}
