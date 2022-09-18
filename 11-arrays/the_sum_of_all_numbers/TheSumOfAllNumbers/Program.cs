using System;
using System.Linq;

namespace TheSumOfAllNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Sum of All Numbers ...");
            Console.WriteLine("This app can calculate the sum of an array of integers.");

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
            int[] values = new int[inputtedNumberStrings.Length];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(inputtedNumberStrings[i]);
            }

            // Calculate the sum of integers
            SumOfIntegers summator = new SumOfIntegers();
            int sum = summator.CalculateSum(values);

            Console.WriteLine($"\nThe sum equals {sum}");

            Console.WriteLine("\nThank you for using The Sum of All Numbers");
        }
    }
}
