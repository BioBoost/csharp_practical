using System;

namespace MultiplesOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Multiples of Three ...");
            Console.WriteLine("This app prints out the first 10 multiples of three");

            MultipleGenerator generator = new MultipleGenerator();
            int[] multiples = generator.generate();

            Console.WriteLine("\nList of multiples:");
            if (multiples != null)
            {
                foreach (int multiple in multiples)
                {
                    Console.Write($"{multiple} ");
                }
            }

            Console.WriteLine("\n\nThank you for using Multiples of Three");
        }
    }
}
