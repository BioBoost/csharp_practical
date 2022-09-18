using System;

namespace Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Super Duper String Reverser");
            Console.Write("Please enter a text to reverse: ");
            string text = Console.ReadLine();

            StringReverser reverser = new StringReverser();

            Console.WriteLine($"\n{text}\n\nreversed:\n{reverser.Reverse(text)}");
        }
    }
}
