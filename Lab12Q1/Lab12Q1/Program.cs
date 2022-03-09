using System;

namespace Lab12Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            double area = AreaOfRectangle(length, width);
            double perimeter = PerimeterOfRectangle(length, width);
            Console.WriteLine($"Area of rectangle is :{area}");
            Console.WriteLine($"Perimeter of rectangle is :{perimeter}");
            Console.ReadKey();
        }

        static double AreaOfRectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }

        static double PerimeterOfRectangle(double length, double width)
        {
            double perimeter = (2 * length) + (2 * width);
            return perimeter;
        }

    }
}
