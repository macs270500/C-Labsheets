using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZeroExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var continueloop = true;
            do
            {
                try
                {
                    Console.Write("Enter an integer numerator:");
                    var numerator = double.Parse(Console.ReadLine());
                    Console.Write("Enter an integer denominator:");
                    var denominator = double.Parse(Console.ReadLine());
                    var result = numerator / denominator;
                    Console.WriteLine($"Result: {numerator}/{denominator} = {result}");
                    continueloop = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"{formatException.Message}");
                    Console.WriteLine("You must enter two integers. Please try again.");
                }
                catch (DivideByZeroException DBZE)
                {
                    Console.WriteLine($"{DBZE.Message}");
                    Console.WriteLine("Zero is an invalid denominator. Please try again");
                }
            } while (continueloop);
            Console.ReadKey();
        }
    }
}
