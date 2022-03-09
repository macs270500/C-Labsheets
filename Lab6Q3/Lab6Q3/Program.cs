using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num,greatest,smallest,sum,average;
            int count;
            greatest = 0;
            smallest = 10;
            sum = 0;
            for (count = 1; count < 4; count++)
            {
                Console.Write("Enter a number:");
                num =Double.Parse(Console.ReadLine());
                if (count == 1)
                {
                    greatest = num;
                    smallest = num;
                }
                else if (num > greatest)
                {
                    greatest = num;
                }
                else if (num<smallest)
                {
                    smallest = num;
                }
                sum += num;

            }
            average = sum / 3;
            Console.WriteLine($"The smallest number is {smallest}");
            Console.WriteLine($"The largest number is {greatest}");
            Console.WriteLine($"The sum of the 3 numbers are {sum}");
            Console.WriteLine($"The average of the 3 numbers are {average}");
            Console.ReadKey();

        }
    }
}
