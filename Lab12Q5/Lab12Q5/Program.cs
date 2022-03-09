using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers to compare");
            Console.Write("Num 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Num 2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Num 3: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The maximum, minimum, sum and average of {num1}, {num2} & {num3} are:\n" +
               $"Maximum: {max(num1, num2, num3)}\nMinimum: {min(num1, num2, num3)}\nSum: {sum(num1, num2, num3)}\nAverage: {average(num1,num2,num3)}");
            Console.ReadKey();
        }

        static double max(double num1,double num2 , double num3)
        {
            double maximum = 0;
            if ((num1 > num2) && (num1>num3))
            {
                maximum = num1;
            }
            else if((num2>num1)&&(num2>num3))
            {
                maximum = num2;
            }
            else
            {
                maximum = num3;
            }
            return maximum;
        }
        static double min(double num1, double num2, double num3)
        {
            double minimum = 0;
            if ((num1 < num2) && (num1 < num3))
            {
                minimum = num1;
            }
            else if ((num2 < num1) && (num2 < num3))
            {
                minimum = num2;
            }
            else
            {
                minimum = num3;
            }
            return minimum;
        }

        static double sum(double num1, double num2, double num3)
        {
            double Summation = num1 + num2 + num3;
            return Summation;
        }

        static double average(double num1, double num2, double num3)
        {
            double Average = (num1 + num2 + num3)/3;
            return Average;
        }
    }
}
