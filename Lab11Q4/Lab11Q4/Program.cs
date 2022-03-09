using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students:");
            int students = int.Parse(Console.ReadLine());
            Console.Write("Enter number of subjects:");
            int subject = int.Parse(Console.ReadLine());
            int[,] marks = new int[students, subject];
            Console.WriteLine();

            for (int row = 0; row < students; row++)
            {
                Console.WriteLine($"Enter marks for Student{row + 1}...");
                for (int col = 0; col < subject; col++)
                {
                    Console.Write($"Enter marks for subject{col + 1}:");
                    marks[row, col] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Displaying the contents if the 2D array...");
            for (int row = 0; row < students; row++)
            {
                for (int col = 0; col < subject; col++)
                {
                    Console.Write($"{marks[row, col]}\t");
                }
                Console.WriteLine();
            }

            for (int row = 0; row < students; row++)
            {
                int max = int.MinValue, min = int.MaxValue, total = 0;
                Console.WriteLine($"Processd marks for student{row + 1}...");
                for (int col = 0; col < subject; col++)
                {
                    if (marks[row, col] > max)
                    {
                        max = marks[row, col];
                    }
                    if (marks[row, col] < min)
                    {
                        min = marks[row, col];
                    }
                    total += marks[row, col];
                }
                Console.WriteLine($"Min:{min}");
                Console.WriteLine($"Max:{max}");
                Console.WriteLine($"Total:{total}");
                Console.WriteLine($"Average:{total / subject}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
