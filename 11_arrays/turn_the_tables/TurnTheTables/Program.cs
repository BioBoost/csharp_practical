using System;

namespace TurnTheTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Turn the Tables ...");
            Console.WriteLine("This app can calculate a table of multiplications.");
            Console.Write("\nPlease enter your desired multiplier: ");
            int multiplier = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lets output an example:");

            int[] indices = new int[10];
            for (int i = 0; i < indices.Length; i++)
            {
                indices[i] = i;
            }

            int[] multipliers = new int[indices.Length];
            for (int i = 0; i < multipliers.Length; i++)
            {
                multipliers[i] = multiplier;
            }

            ArrayMultiplier arrayMultiplier = new ArrayMultiplier();
            int[] tableOfMultiplications = arrayMultiplier.Multiply(indices, multipliers);

            // Outputting result
            Console.WriteLine($"\nThe table of multiplication for the number {multiplier}:");
            if (tableOfMultiplications != null)
            {
                for (int i = 0; i < tableOfMultiplications.Length; i++)
                {
                    Console.WriteLine($"{indices[i]} x {multipliers[i]} = {tableOfMultiplications[i]}");
                }
            }

            Console.WriteLine("\nThank you for using Turn the Tables");
        }
    }
}
