

using System;

namespace Lab12Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of hours worked: ");
            double HrsWorked = double.Parse(Console.ReadLine());
            Console.Write("Enter pay rate: ");
            double PayRate = double.Parse(Console.ReadLine());
            Console.WriteLine($"Gross pay is : {CalcGrossPay(HrsWorked, PayRate)}");
            Console.ReadKey();
        }

        static double CalcGrossPay(double HrsWrkd, double payRate)
        {
            double grosspay;
            if (HrsWrkd <= 40)
            {
                grosspay = HrsWrkd * payRate;
            }
            else
            {
                grosspay = (40 * payRate) + ((HrsWrkd - 40) * (1.5 * payRate));
            }
            return grosspay;
        }
    }
}
