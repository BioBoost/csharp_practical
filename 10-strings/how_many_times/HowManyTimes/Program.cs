using System;

namespace HowManyTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to How Many Times ...");
            Console.WriteLine("This app can determine the number of occurrences of a word inside a text.");
            Console.WriteLine("Please enter a text:");
            string text = Console.ReadLine();
            Console.Write("Please enter a word to search for: ");
            string word = Console.ReadLine();

            StringFinder finder = new StringFinder();

            int times = finder.SearchAndCount(text, word);
            Console.WriteLine($"\nThe word \"{word}\" was found {times} times inside the text");
        }
    }
}
