using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Question_2018
{
    class Program
    {
        static string GradeToMark(string grade)

        {
            double mark = 0;
            if (grade == "A+")
            {
                mark = 12;
            }
            else if (grade == "A")
            {
                mark = 10;
            }
            else if (grade == "B")
            {
                mark = 8;
            }
            else if (grade == "C")
            {
                mark = 6;
            }
            else
            {
                mark = 0;

            }
            return mark.ToString();
        }
        static void Allowances(double total,double yrlyincome)
        {
            double monthlystipend = 0, intallowance = 0;

            switch (yrlyincome)
            {
                case double income when (income < 100000):
                    if (total < 15)
                    {
                        monthlystipend = 4000;
                        intallowance = 600;
                    }
                    else if (total >= 15 && total <= 20)
                    {
                        monthlystipend = 5000;
                        intallowance = 800;
                    }
                    else if (total >= 20)
                    {
                        monthlystipend = 6000;
                        intallowance = 1000;
                    }
                    break;
                case double income when (income >= 100000):
                    if (total < 15)
                    {
                        monthlystipend = 2000;
                        intallowance = 400;
                    }
                    else if (total >= 15 && total <= 20)
                    {
                        monthlystipend = 3000;
                        intallowance = 500;
                    }
                    else if (total >= 20)
                    {
                        monthlystipend = 4000;
                        intallowance = 600;
                    }
                    break;
                    
                                       
            }
            Console.WriteLine($"Mothly Stipend: Rs{monthlystipend}");
            Console.WriteLine($"Internet Allowance: Rs{intallowance}");
        }

        static void Main(string[] args)
        {   double mark1= 0,mark2=0,total,yrlyincome=0;        
                Console.Write("Enter Grade for subject 1:");
                mark1 = double.Parse(GradeToMark(Console.ReadLine()));
                Console.Write("Enter Grade for subject 2:");
                mark2 = double.Parse(GradeToMark(Console.ReadLine()));
                total = mark1 + mark2;
                Console.Write("Enter Yearly Income:");
                yrlyincome = double.Parse(Console.ReadLine());
                Allowances(total, yrlyincome);                
            Console.ReadKey();            
        }
    }
}
