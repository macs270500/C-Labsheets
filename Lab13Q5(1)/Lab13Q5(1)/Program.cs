using System;

namespace Lab13Q5_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Yearly Income:");
            double yrlyIncome = double.Parse(Console.ReadLine());
            Console.Write("Enter Number of Dependents:");
            double dependents = double.Parse(Console.ReadLine());
            ComputeTax(yrlyIncome, dependents, out double threshold, out double chargeable, out double monthlyTax);
            Console.Write($"Threshold : {threshold.ToString("C2")} \nChargeable Income : {chargeable.ToString("C2")}\nMonthly Tax : {monthlyTax.ToString("C2")}");
            Console.ReadKey();
        }

        static void ComputeTax(double yrlyIncome, double dependents, out double threshold, out double chargeable, out double monthlyTax)
        {
            switch (dependents)
            {
                case double dp when (dp == 1):
                    threshold = 385000;
                    break;
                case double dp when (dp >= 2):
                    threshold = 445000;
                    break;
                default:
                    threshold = 275000;
                    break;
            }
            if (threshold >= yrlyIncome)
            {
                threshold = 0;
                chargeable = 0;
                monthlyTax = 0;
            }
            else
            {
                chargeable = yrlyIncome - threshold;
                monthlyTax = 0.15 / 12 * chargeable;
            }
        }
    }
}
