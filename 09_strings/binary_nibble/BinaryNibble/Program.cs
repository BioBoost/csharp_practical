using System;

namespace BinaryNibble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Nibble.");

            int value = 0;
            do
            {
                Console.Write("Please enter a positive value[0, 255]: ");
                value = Convert.ToInt32(Console.ReadLine());
            } while (value < 0 || value > 255);

            NumberSystemConverter converter = new NumberSystemConverter();
            string binary = converter.DecimalToBinary(value);

            Console.WriteLine($"The decimal value {value}, is represented in binary as: {binary}");
        }
    }
}
