using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_question
{
    class Program
    {
        static void Main(string[] args)
        {
            string grade1, grade2;
            double mark1, mark2, totalmark, yrlyincome, monthlystipend,intallowance;
            Console.WriteLine("use upper case only");
            Console.Write("Enter Grade for subject 1:");
            grade1 = Console.ReadLine();
            Console.Write("Enter Grade for subject 2:");
            grade2 = Console.ReadLine();
            monthlystipend = 0;
            intallowance = 0;
            if (grade1 == "A+")
            {
                mark1 = 12;
            }
            else if (grade1 == "A")
            {
                mark1 = 10;
            }
            else if (grade1 == "B")
            {
                mark1 = 8;
            }
            else if (grade1 == "C")
            {
                mark1 = 6;
            }
            else
            {
                mark1 = 0;
            }
            if (grade2 == "A+")
            {
                mark2 = 12;
            }
            else if (grade2 == "A")
            {
                mark2 = 10;
            }
            else if (grade2 == "B")
            {
                mark2 = 8;
            }
            else if (grade2 == "C")
            {
                mark2 = 6;
            }
            else
            {
                mark2 = 0;
            }
            totalmark = mark1 + mark2;
            Console.Write("Enter yearly income:");
            yrlyincome = Double.Parse(Console.ReadLine());
            switch (yrlyincome)
            {
                case double income when (income < 100000):
                    if (totalmark < 15)
                    {
                        monthlystipend = 4000;
                        intallowance = 600;
                    }
                    else if (totalmark>=15 && totalmark<=20)
                    {
                        monthlystipend = 5000;
                        intallowance = 800;
                    }
                    else if (totalmark >= 20)
                    {
                        monthlystipend = 6000;
                        intallowance = 1000;
                    }
                    break;
                case double income when (income >= 100000):
                    if (totalmark < 15)
                    {
                        monthlystipend = 2000;
                        intallowance = 400;
                    }
                    else if (totalmark >= 15 && totalmark <= 20)
                    {
                        monthlystipend = 3000;
                        intallowance = 500;
                    }
                    else if (totalmark >= 20)
                    {
                        monthlystipend = 4000;
                        intallowance = 600;
                    }
                    break;

            }
            Console.WriteLine($"Monthly stipend : Rs{monthlystipend}");
            Console.WriteLine($"Internet Allowance: Rs{intallowance}");
            Console.ReadKey();
        }
    }
}
