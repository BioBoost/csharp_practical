using System;

namespace FundamentalCalculus
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Welcome to Fundamental Calculus\n");

            Console.WriteLine($"3 + 5 = {calculator.Add(3, 5)}");
            Console.WriteLine($"3 + (-5) = {calculator.Add(3, -5)}");

            Console.WriteLine($"7 - 2 = {calculator.Subtract(7, 2)}");
            Console.WriteLine($"7 - (-2) = {calculator.Subtract(7, -2)}");

            Console.WriteLine($"4 * 6 = {calculator.Multiply(4, 6)}");
            Console.WriteLine($"4 * (-6) = {calculator.Multiply(4, -6)}");

            // TODO: Add further examples yourself
        }
    }
}
