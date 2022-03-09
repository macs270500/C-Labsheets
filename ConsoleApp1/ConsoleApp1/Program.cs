using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
       
    {
        static string Grade(double mark)
        {
            string award;

            switch(mark)
            {
                case double mk when (mk > 80):
                    award = "A";
                    break;
                case double mk when (mk > 60):
                    award = "B";
                    break;

                default:
                    award = "C";
                    break;
            }
            return award;
        }
        static void Main(string[] args)
        {
            double mark;
            Console.Write("Enter mark:");
            mark = double.Parse(Console.ReadLine());

            string award = Grade(mark);
            Console.WriteLine($"The award is: {award}");

            Console.ReadKey();
        }
    }
}
