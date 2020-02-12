using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Abbreviate Thhis ...");

            Abbreviator abbr = new Abbreviator();

            string text = "Laughing Out Loud";
            Console.WriteLine($"{abbr.Abbreviate(text)} means {text}");
        }
    }
}
