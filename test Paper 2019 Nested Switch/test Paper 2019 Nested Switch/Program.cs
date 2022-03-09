using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Paper_2019_Nested_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter years of service: ");
            int years = int.Parse(Console.ReadLine());
            Console.Write("Enter employee type (permanent or temporary): ");
            string type = Console.ReadLine();
            CalculateLoan(type, years, out double amount, out int interestRate);
            Console.WriteLine($"Loan Amount: Rs{amount}");
            Console.WriteLine($"Interest Rate:{interestRate}");
            Console.ReadKey();
        }
        static void CalculateLoan(string type, int years,out double amount,out int interestRate)
        {
            switch (type)
            {
                case "Permanent":
                    switch (years)
                    {
                        case int yrs when (yrs > 10):
                            amount = 600000;
                            break;
                        case int yrs when (yrs >= 5 && yrs <= 10):
                            amount = 300000;
                            break;
                        default:
                            amount = 100000;
                            break;                       
                    }
                    break;
                default:
                    switch (years)
                    {
                        case int yrs when (yrs > 10):
                            amount = 500000;
                            break;
                        case int yrs when (yrs >= 5 && yrs <= 10):
                            amount = 200000;
                            break;
                        default:
                            amount = 50000;
                            break;
                    }
                    break;                   
            }
            switch (amount)
            {
                case 600000:
                    interestRate = 5;
                    break;
                case 500000:
                    interestRate = 6;
                    break;
                case 300000:
                    interestRate = 7;
                    break;
                case 200000:
                    interestRate = 8;
                    break;
                case 100000:
                    interestRate = 9;
                    break;
                default:
                    interestRate = 10;
                    break;
            }
        }
    }
}
