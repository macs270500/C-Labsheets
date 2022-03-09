using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17Q4
{
    class DivideByZero
    {
        static void Main(string[] args)
        {
            var continueLoop = true;
            do
            {
                try
                {
                    Console.Write("Enter an integer numerator:");
                    var numerator = int.Parse(Console.ReadLine());
                    Console.Write("Enter an integer denominator:");
                    var denominator = int.Parse(Console.ReadLine());
                    var result = numerator / denominator;
                    Console.WriteLine($"Result:\n{numerator}/{denominator} = {result}");
                    continueLoop = false;
                }
                catch(FormatException formatException)
                {
                    Console.WriteLine($"{formatException.Message}");
                    Console.WriteLine("You must enter 2 integer numbers. Please try again");
                }
                catch (DivideByZeroException DBZException)
                {
                    Console.WriteLine($"{DBZException.Message}");
                    Console.WriteLine("Zero is an invalid denominator. Please try again");
                }
            }
            while (continueLoop);
            Console.ReadKey();
        }
    }
}
