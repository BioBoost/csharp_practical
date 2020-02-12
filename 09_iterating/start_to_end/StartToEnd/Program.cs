using System;

namespace StartToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Series series = new Series();
            Console.WriteLine("This app can sum a series of numbers.");

            Console.WriteLine($"\nSum(1, 5) results in {series.Sum(1, 5)}");
            Console.WriteLine($"Sum(0, 0) results in {series.Sum(0, 0)}");
            Console.WriteLine($"Sum(1, 2, 8) results in {series.Sum(1, 2, 8)}");

            Console.WriteLine("\nThanks for using our app.");
        }
    }
}
