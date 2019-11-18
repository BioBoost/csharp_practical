using System;

namespace BiggestOfThemAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Biggest of them All ...");
            Console.WriteLine("This app can determine the biggest number in an array of numbers.");

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
            int[] values = new int[inputtedNumberStrings.Length];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(inputtedNumberStrings[i]);
            }

            // Determine the maximum number
            ArrayAnalyzer analyzer = new ArrayAnalyzer();
            int max = analyzer.BiggestValue(values);
            int maxIndex = analyzer.BiggestIndex(values);

            Console.WriteLine($"\nThe maximum number is {max} @ index {maxIndex}");

            Console.WriteLine("\nThank you for using Biggest of them All");
        }
    }
}
