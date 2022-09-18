using System;

namespace TimeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            Console.WriteLine("Welcome to your personal time machine.\n");

            Console.WriteLine("The current time is");
            clock.PrintToTerminal();

            // TODO: Request number of minutes to add from the user
            int minutes = 0;

            // TODO: Request number of hours to add from the user
            int hours = 0;

            // TODO: Add the actual values to the current clock time
            // Call the AddMinutes() method
            // Call the AddHours() method

            Console.WriteLine("\nCongratz. You jumped forward in time to");
            clock.PrintToTerminal();
        }
    }
}
