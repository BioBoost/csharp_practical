using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Manipulator\n");

            Console.WriteLine("Let's reverse some numbers: ");
            Console.WriteLine($" The inverted value of 123 is {Manipulator.Reverse(123)}");
            Console.WriteLine($" The inverted value of 9200 is {Manipulator.Reverse(9200)}");
            Console.WriteLine($" The inverted value of 111 is {Manipulator.Reverse(111)}");
            Console.WriteLine($" The inverted value of 0 is {Manipulator.Reverse(0)}");

            Console.WriteLine("\nLet's complement some numbers: ");
            Console.WriteLine($" The complement value of 123 is {Manipulator.Complement(123)}");
            Console.WriteLine($" The complement value of 9200 is {Manipulator.Complement(9200)}");
            Console.WriteLine($" The complement value of 111 is {Manipulator.Complement(111)}");
            Console.WriteLine($" The complement value of 8 is {Manipulator.Complement(8)}");

            Console.WriteLine("\nNow let's sum some digits: ");
            Console.WriteLine($" The sum of digits of 532 is {Manipulator.DigitSum(532)}");
            Console.WriteLine($" The sum of digits of 231324 is {Manipulator.DigitSum(231324)}");
            Console.WriteLine($" The sum of digits of 23 is {Manipulator.DigitSum(23)}");
            Console.WriteLine($" The sum of digits of 8 is {Manipulator.DigitSum(8)}");
        }
    }
}
