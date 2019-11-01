using System;

namespace ParenthesesChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Parentheses Checker");
            Console.WriteLine("Please enter a single line of code below to check:");
            string code = Console.ReadLine();

            CodeLinter linter = new CodeLinter();
            if (linter.HasMatchingParentheses(code))
            {
                Console.WriteLine($"\nThe code snippet is valid.");
            }
            else
            {
                Console.WriteLine($"\nThe code snippet contains unmatched parentheses.");
            }
        }
    }
}
