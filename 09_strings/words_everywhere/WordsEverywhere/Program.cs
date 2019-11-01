using System;

namespace WordsEverywhere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Word Counter App.");
            Console.WriteLine("Please enter a text. This app will then count the number of words.");
            Console.WriteLine("Your text:");
            string text = Console.ReadLine();

            WordCounter counter = new WordCounter();

            Console.WriteLine($"\nThe text contains {counter.CountWords(text)} words");
        }
    }
}
