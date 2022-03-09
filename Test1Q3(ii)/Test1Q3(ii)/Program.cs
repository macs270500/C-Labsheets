using System;

namespace Test1Q3_ii_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an alphabet:");
            char alpha = Char.Parse(Console.ReadLine());

            switch (alpha)
            {
                case char beta when (beta == char.Parse("a") || beta == char.Parse("e") || beta == char.Parse("i")
              || beta == char.Parse("o") || beta == char.Parse("u") || beta == char.Parse("A")
              || beta == char.Parse("E") || beta == char.Parse("I") || beta == char.Parse("O")
              || beta == char.Parse("U")):
                    Console.WriteLine($"'{alpha}' is a Vowel'");
                    break;
                default:
                    if (alpha == char.Parse("0") || alpha == char.Parse("1") || alpha == char.Parse("2")
                    || alpha == char.Parse("3") || alpha == char.Parse("4") || alpha == char.Parse("5")
                    || alpha == char.Parse("6") || alpha == char.Parse("7") || alpha == char.Parse("8")
                    || alpha == char.Parse("9"))
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

