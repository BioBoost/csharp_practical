using System;

namespace ThePaintFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Paint Calculator.\n");

            Console.WriteLine("We are painting the following area:");
            Console.WriteLine(" - A square area of 4m by 4m");
            Console.WriteLine(" - A rectangle area of 2m by 6m");
            Console.WriteLine(" - A rectangle area of 10m by 2m");

            PaintCalculator calculator = new PaintCalculator();
            calculator.AddSquare(4);
            calculator.AddRectangle(2, 6);
            calculator.AddRectangle(10, 2);

            Console.WriteLine($"This results in a total area of {calculator.TotalArea} square meters.");

            Console.WriteLine("\nLet us put 2 coats of paint on the walls.");
            Console.WriteLine($"For this we will need {calculator.LitersOfPaint(2)} liters of paint.");
        }
    }
}
