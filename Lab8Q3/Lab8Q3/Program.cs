using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Q3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int count = 1,sum=0;
            while (count<=num)
            {
                sum += count;
                count++;
            }
            Console.WriteLine($"The sum of the first {num} numbers are {sum}");
            Console.WriteLine("Press Enter to access main menu");
            Console.ReadKey();
        }
    }

}
