using System;

namespace SumAndDifference
{
    public class Program
    {
        static int RequestNumber()
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            return number;
        }

        static int Add(int first, int second)
        {
            return (first + second);
        }

        // TODO Create a method Subtract that substracts
        // a second argument from a first argument and returns the result.


        static void Main(string[] args)
        {
            // TODO Request two numbers from the user:
            int number1 = 0;
            int number2 = 0;



            // Show user the inputted numbers
            Console.WriteLine("You entered " + number1 + " and " + number2 + ".");

            // TODO Call the Add method and store the result in the variable sum.
            // Make sure to pass the two numbers as arguments to the method.
            int sum = 0;



            // Result of sum
            Console.WriteLine("\nTheir sum: " + sum);

            // TODO Call the Subtract method and store the result in the variable difference.
            // Make sure to pass the two numbers as arguments to the method.
            int difference = 0;



            // Result of sum
            Console.WriteLine("\nTheir difference: " + difference);
        }
    }
}
