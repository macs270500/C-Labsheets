using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1;i<=num;i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("*");                    
                }
                Console.WriteLine("");

            }
            Console.ReadKey();
        }
    }
}
