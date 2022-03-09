using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture20___Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a count down:");
            int CDown = int.Parse(Console.ReadLine());
            CountDown(CDown);
            Console.ReadKey();
        }
        private static void CountDown(int x)
        {
            if (x > 0)
            {
                Console.WriteLine(x);               
                CountDown(x - 1);
            }
        }
    }
}
