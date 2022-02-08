using System;

namespace SeriesOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Series of Square");

            Console.WriteLine("\nLet's determine the sum of the following series:");
            Console.WriteLine("1^2 + 2^2 + 3^2 + 4^2 + 5^2\n");

            Console.WriteLine($"- Using summation: {SquaredSeries.SeriesSum(5)}");
            Console.WriteLine($"- Using formula: {SquaredSeries.CalculateSumSeries(5)}");

            if (SquaredSeries.SeriesSum(5) == SquaredSeries.CalculateSumSeries(5))
            {
                Console.WriteLine("\nSuper! The formula seems to be correct.");
            }
            else
            {
                Console.WriteLine("\nHmmm, something is wrong. The formula seems to be incorrect.");
            }
        }
    }
}
