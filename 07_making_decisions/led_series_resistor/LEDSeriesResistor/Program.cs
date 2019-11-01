using System;

namespace LEDSeriesResistor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LED series resistor calculator");
            Console.WriteLine("Your place to calculate your series resistors for LEDs.");
            Console.WriteLine("----------------------------------------------------");

            // Create object of ResistorCalculator
            ResistorCalculator resistorCalculator = new ResistorCalculator();

            // Request the supply voltage of the user
            Console.Write("\nPlease enter your supply voltage [V]: ");
            resistorCalculator.SupplyVoltage = Convert.ToDouble(Console.ReadLine());

            // Request the voltage over the LED from the user
            Console.Write("Please enter the voltage drop over the LED [V]: ");
            resistorCalculator.LedVoltage = Convert.ToDouble(Console.ReadLine());

            // Request the current through the LED from the user
            Console.Write("What current do you want to drive through the LED [A]: ");
            resistorCalculator.Current = Convert.ToDouble(Console.ReadLine());

            // Determine the series resistor using the supplied information from the user
            double seriesResistor = resistorCalculator.CalculateSeriesResistor();

            // Output the result
            Console.WriteLine($"\nYou will need a resistor of {seriesResistor} Ohm");
        }
    }
}
