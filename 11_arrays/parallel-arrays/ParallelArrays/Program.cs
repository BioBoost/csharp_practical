using System;

namespace ParallelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Parallel Arrays - A simple array helper ...\n");

            Console.WriteLine("Let's make the sum of following arrays:");
            int[] first = { 123, 34, 54, 34 };
            int[] second = { 12, 756, 43, 56 };
            int[] result = ArrayHelper.SumByElements(first, second);

            Console.WriteLine($"> { String.Join(',', first) }");
            Console.WriteLine($"> { String.Join(',', second) }");
            Console.WriteLine("\nSum:");
            Console.WriteLine($"> { String.Join(',', result) }");

            Console.WriteLine($"\nThe first array contains {ArrayHelper.CountDifferentFrom(first, 34)} numbers" +
                $" different from 34");

            Console.WriteLine("\nLet's double the second array in size:");
            second = ArrayHelper.DoubleInSize(second);
            Console.WriteLine($"> { String.Join(',', second) }");
        }
    }
}
