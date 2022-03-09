using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Q3
{
    class Main_Menu
    {
        static void Main(string[] Args)
        {
            int selection = 0;
           
            while (selection != 3)
            {
            Console.WriteLine("* * * * *Main Menu* * * * *");
            Console.WriteLine("1.Calculate sum of first n numbers");
            Console.WriteLine("2.Calculate sum of first n odd numbers");
            Console.WriteLine("3.Exit");
            selection = int.Parse(Console.ReadLine());
            
                switch (selection)
                {
                    case 1:
                        Program.Main(null);                
                        break;
                    case 2:
                        sumOdd.Main(null);                        
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
                
            }

        }
    }
}
