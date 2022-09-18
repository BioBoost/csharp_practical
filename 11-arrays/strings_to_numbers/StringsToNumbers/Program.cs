using System;

namespace StringsToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Strings to Numbers ...");
            Console.WriteLine("This app can convert your input to an array of integers.");

            Console.WriteLine("\nPlease enters numbers separated by spaces.");
            Console.WriteLine("Once finished, hit enter.");

            // Request all numbers from user
            string userInput;
            do
            {
                Console.Write("\nNumbers: ");
                userInput = Console.ReadLine().Trim();
            } while (userInput == "");

            // Split them into array of strings based on space (' ') between numbers
            string[] inputtedNumberStrings = userInput.Split(' ');

            // Convert array of strings to array of ints
            StringArrayConverter converter = new StringArrayConverter();
            int[] values = converter.ConvertToIntegers(inputtedNumberStrings);

            // Output values
            Console.WriteLine("\nAfter a nice conversion:");
            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine($"{values[i] }");
                }
            }

            Console.WriteLine("\nThank you for using Strings to Numbers");
        }
    }
}
