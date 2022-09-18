using System;

namespace HoloGram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pangram checker.");

            string pangram = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("The most famous pangram is:");
            Console.WriteLine(pangram);

            PangramChecker checker = new PangramChecker();
            bool result = checker.IsPangram(pangram + "\n");
            if (result)
            {
                Console.WriteLine("This application agrees that this is a pangram.");
            }
            else
            {
                Console.WriteLine("Sorry, there is still a bug in this app.");
            }
        }
    }
}
