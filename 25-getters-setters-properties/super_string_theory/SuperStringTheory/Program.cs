using System;

namespace SuperStringTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Super String Theory\n");

            // Append
            Console.WriteLine("Lets append the word \" World\" to \"Hello\"");
            SuperString hello = new SuperString();

            hello.SetText("Hello");
            Console.WriteLine(" > Before: " + hello.GetText());

            hello.Append(" World");
            Console.WriteLine(" > After: " + hello.GetText());

            // IsValidNumber
            Console.WriteLine("\nLet's check some numbers ...");
            SuperString number = new SuperString();

            number.SetText("1234");
            Console.WriteLine($"Is {number.GetText()} a valid number? " + number.IsValidNumber());

            number.SetText("SDFNBDSF");
            Console.WriteLine($"Is {number.GetText()} a valid number? " + number.IsValidNumber());

            number.SetText("#88");
            Console.WriteLine($"Is {number.GetText()} a valid number? " + number.IsValidNumber());

            // Trim
            Console.WriteLine("\nOK, now for some trimming ...");
            SuperString text = new SuperString();

            text.SetText("  Hello There!");
            Console.Write($"If we trim at the beginning \"{text.GetText()}\"");
            text.TrimStart();
            Console.WriteLine($", then we get \"{text.GetText()}\"");

            text.SetText("There is no place like home!    ");
            Console.Write($"If we trim at the beginning \"{text.GetText()}\"");
            text.TrimStart();
            Console.WriteLine($", then we get \"{text.GetText()}\"");
        }
    }
}
