using System;

namespace Test1Q3Corrected
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an alphabet : ");
            string alphabet = Console.ReadLine();
            if (int.TryParse(alphabet, out int num))
            {
                Console.WriteLine($"Invalid! {num} is a number");
            }
            else
            {
                switch (alphabet)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.WriteLine($"'{alphabet}' is a vowel");
                        break;
                    default:
                        Console.WriteLine($"'{alphabet}' is a consonant");
                        break;
                }
            }
            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}
