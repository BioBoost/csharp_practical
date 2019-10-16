using System;

namespace GreatestCommonFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the greatest common factor finder.");

            Console.Write("Please input your first value: ");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input your second value: ");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            MathHelper mathHelper = new MathHelper();
            int gcf = mathHelper.DetermineGreatestCommonFactor(firstValue, secondValue);

            Console.WriteLine($"The greatest common factor of {firstValue} and {secondValue} is: {gcf}");
        }
    }
}
