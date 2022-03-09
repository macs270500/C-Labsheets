using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students:");
            int stu = int.Parse(Console.ReadLine()), pass = 0, fail = 0;
            for (int i = 1; i <= stu; i++)
            {
                Console.Write($"Enter mark{i}:");
                int mark = int.Parse(Console.ReadLine());
                if (mark >= 40)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }

            }
            Console.WriteLine($"Out of {stu} students, {pass} have passed and {fail} have failed");
            Console.ReadKey();
        }
    }
}
