

using System;

namespace Test1Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an alphabet:");
            string alpha = Console.ReadLine();
            switch (alpha)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    Console.WriteLine($"'{alpha}' is a Vowel'");
                    break;
                default:
                    if (alpha == "0" || alpha == "1" || alpha == "2" || alpha == "3" || alpha == "4"
                        || alpha == "5" || alpha == "6" || alpha == "7" || alpha == "8" || alpha == "9")
                    {
                        Console.WriteLine($"Invalid!'{alpha}' is a number");
                    }
                    else
                    {
                        Console.WriteLine($"'{alpha}' is a Consonant");
                    }
                    break;
            }

            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}
