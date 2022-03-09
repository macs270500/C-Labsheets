using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Q1
{
    class Scope
    {
        private static int x = 1;
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"Local method x Main() is {x}");

            UseLocalVariable();

            UseStaticVariable();

            UseStaticVariable();

            Console.WriteLine($"\nLocal x in method Main() is {x}");

            Console.ReadKey();
        }

        static void UseLocalVariable()
        {
            int x  = 25;
            Console.WriteLine($"\nlocal x on  entering method UseLocalVariable is {x}");
            ++x;
            Console.WriteLine($"\nlocal x before exiting method UseLocalVariable is {x}");
        }

        static void UseStaticVariable()
        {
            Console.WriteLine($"\nstatic variable x on entering method UseStaticVariable is {x}");
            x *= 10;
            Console.WriteLine($"\nstatic variable x before exiting method UseStaticVariable is {x}"); 
        }
    }
}
