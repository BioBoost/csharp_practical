using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the AppleCake generator");
            AppleCakeGenerator generator = new AppleCakeGenerator();
            string output = generator.Generate(1, 15);
            Console.WriteLine(output);
        }
    }
}
