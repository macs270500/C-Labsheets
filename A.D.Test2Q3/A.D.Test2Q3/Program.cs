using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.D.Test2Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the years of service:");
            int yrsService = int.Parse(Console.ReadLine());
            Console.Write("Enter the salary:");
            double salary = double.Parse(Console.ReadLine());
            Compute(yrsService,salary,out double loanAmt,out int intRate);
            Console.WriteLine($"Maximum loan amount:{loanAmt}");
            Console.WriteLine($"Interest rate:{intRate}");
            Console.ReadKey();
        }

        static void Compute(int yrsService, double salary, out double loanAmt, out int intRate)
        {
            if (yrsService < 5)
            {
                if (salary < 50000)
                {
                    loanAmt = 300000;
                }
                else
                {
                    loanAmt = 500000;
                }
            }
            else if(yrsService>=5 && yrsService < 10)
            {
                if (salary < 50000)
                {
                    loanAmt = 400000;
                }
                else
                {
                    loanAmt = 700000;
                }
            }
            else
            {
                if (salary < 50000)
                {
                    loanAmt = 700000;
                }
                else
                {
                    loanAmt = 1000000;
                }

            }
            if (loanAmt < 600000)
            {
                intRate = 8;
            }
            else
            {
                intRate = 6;
            }
        }
    }
}
