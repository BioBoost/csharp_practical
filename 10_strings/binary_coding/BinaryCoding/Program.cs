using System;

namespace BinaryCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary converter can convert a binary number to decimal.");

            Console.WriteLine("Try it out. Just enter a binary value here: ");
            string binary = Console.ReadLine().Trim();

            BinaryConverter converter = new BinaryConverter();
            int decimalValue = converter.ToDecimal(binary);
            Console.WriteLine($"This equals {decimalValue}");
        }
    }
}
