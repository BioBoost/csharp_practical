using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Palindrome");
            Console.Write("Please enter a word to check: ");
            string word = Console.ReadLine();

            PalindromeChecker checker = new PalindromeChecker();
            bool isPalindrome = checker.IsPalindrome(word);

            Console.WriteLine($"\n{word} is{(isPalindrome ? "" : " not")} a palindrome");
        }
    }
}
