using System;
using System.Diagnostics;

namespace ReplacePerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ReplacePerformance");
            Console.WriteLine("\nPlease enter a sentence to start with:");
            string text = Console.ReadLine();

            Console.Write("\nNow please enter a word to search for: ");
            string wordToReplace = Console.ReadLine();

            Console.Write("Now please enter a word to replace it with: ");
            string replacement = Console.ReadLine();

            StringHelper stringhelper = new StringHelper();

            Stopwatch watch = new Stopwatch();

            watch.Start();
            string alteredTextLib = stringhelper.ReplaceUsingLibrary(text, wordToReplace, replacement);
            watch.Stop();
            long libraryTicks = watch.ElapsedTicks;

            watch.Restart();
            string alteredTextOwn = stringhelper.ReplaceUsingOwnImplementation(text, wordToReplace, replacement);
            watch.Stop();
            long ownImplementationTicks = watch.ElapsedTicks;

            Console.WriteLine("\nThe result is:");
            Console.WriteLine($"Library (took {libraryTicks} ticks): {alteredTextLib}");
            Console.WriteLine($"Own (took {ownImplementationTicks} ticks): {alteredTextOwn}");
        }
    }
}
