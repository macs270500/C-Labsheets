using System;

namespace Lab12Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks:");
            double marks = double.Parse(Console.ReadLine());
            Grade(marks);
            Console.ReadKey();
        }

        static void Grade(double marks)
        {

            switch (marks)
            {
                case double mk when (mk >= 80):
                    Console.WriteLine("Grade is : A");
                    break;
                case double mk when (mk >= 60):
                    Console.WriteLine("Grade is : B");
                    break;
                case double mk when (mk >= 40):
                    Console.WriteLine("Grade is : C");
                    break;
                case double mk when (mk < 40):
                    Console.WriteLine("Grade is : D");
                    break;
            }

        }
    }
}
