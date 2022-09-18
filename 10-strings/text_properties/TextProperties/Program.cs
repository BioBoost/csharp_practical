using System;

namespace TextProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# String Analyzer");
            Console.WriteLine("Please enter a string to analyze:");
            string text = Console.ReadLine();

            StringAnalyzer analyzer = new StringAnalyzer();
            Console.WriteLine($"\nNumber of vowels: {analyzer.NumberOfVowels(text)}");
            Console.WriteLine($"Number of consonants: {analyzer.NumberOfConsonants(text)}");
            Console.WriteLine($"Number of digits: {analyzer.NumberOfDigits(text)}");
            Console.WriteLine($"Number of lowercase letters: {analyzer.NumberOfLowercaseLetters(text)}");
            Console.WriteLine($"Number of uppercase letters: {analyzer.NumberOfUppercaseLetters(text)}");
            Console.WriteLine($"Number of whietespace characters: {analyzer.NumberOfWhitespaceCharacters(text)}");
        }
    }
}
