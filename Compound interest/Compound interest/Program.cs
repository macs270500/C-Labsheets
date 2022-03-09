using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_interest
{
    class Program
    {
        static void Main(string[] args)
        {
            double P, r, newAmount;
            int n;
            Console.WriteLine("Input initial amount of capital");
            P = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of years");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter interest rate");
            r = Double.Parse(Console.ReadLine());
            newAmount=P*(1 + (r / 100)) * n;
            Console.WriteLine($"the new amount is ${newAmount}");
            Console.ReadKey(); 
        }
    }
}
