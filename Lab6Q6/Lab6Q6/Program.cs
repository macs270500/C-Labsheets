using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number to indicate the month & its number of days");
            Console.WriteLine("Enter zero to exit");
            num = -1;

            while (num != 0)
            {
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("January has 31 days");
                        break;
                    case 2:
                        Console.WriteLine("February has 28 or 29 days");
                        break;
                    case 3:
                        Console.WriteLine("March has 31 days");
                        break;
                    case 4:
                        Console.WriteLine("April has 30 days");
                        break;
                    case 5:
                        Console.WriteLine("May has 31 days");
                        break;
                    case 6:
                        Console.WriteLine("June has 30 days");
                        break;
                    case 7:
                        Console.WriteLine("July has 31 days");
                        break;
                    case 8:
                        Console.WriteLine("August has 31 days");
                        break;
                    case 9:
                        Console.WriteLine("September has 30 days");
                        break;
                    case 10:
                        Console.WriteLine("October has 31 days");
                        break;
                    case 11:
                        Console.WriteLine("November has 30 days");
                        break;
                    case 12:
                        Console.WriteLine("December has 31 days");
                        break;
                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }
            }


        }
    }
}
