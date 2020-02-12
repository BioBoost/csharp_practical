using System;

namespace AbsoluteSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Summator. Your absolute truth to summation.\n");

            Summator summator = new Summator();

            int[] numbers = { 1, 2, 3, 4, 5 };

            // Array to string for output
            string numbersListing = "";
            foreach (int number in numbers)
            {
                numbersListing += $"{number} ";
            }
            numbersListing = numbersListing.Trim();

            // Output results
            Console.WriteLine($"The sum of {numbersListing} is {summator.Sum(numbers)}");

            Console.WriteLine("\nThank you for using our app.");
        }
    }
}
