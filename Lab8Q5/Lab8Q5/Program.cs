using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 3;
            string password;
            do
            {
                Console.WriteLine($"You have {count} chance<s> left!");
                Console.Write("Enter Password:");
                password = Console.ReadLine();
                count--;
            } 
            while (password != "visual" && count !=0);
            if (count ==0)
            {
                Console.WriteLine("Welcome to the application");
            }
            else
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Press any key to close the aplication");
            Console.ReadKey();
        }
    }
}
