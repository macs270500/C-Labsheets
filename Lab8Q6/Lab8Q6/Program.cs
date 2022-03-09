using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            double total=0 ,max=0 ,min=0 ,average;
            Console.Write("Enter the number of subjects:");
            int subs = int.Parse(Console.ReadLine());
            for (int i=1; i<=subs;i++)
            {
                Console.Write("Enter marks:");
                double marks = Double.Parse(Console.ReadLine());
                total += marks;
                if (i==1)
                {
                    max = marks;
                    min = marks;
                }
                else if (marks>max)
                {
                    max = marks;
                }
                else if( min>marks)
                {
                    min = marks;
                }
                
            }
            average = total / subs;
            Console.WriteLine($"The Minimum Mark is:{min}");
            Console.WriteLine($"The Maximum Mark is:{max}");
            Console.WriteLine($"The Total Mark is:{total}");
            Console.WriteLine($"The Average Mark is:{average}");
            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }
    }
}
