using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the rectangle calculator");

            // TODO Request the width of the rectangle from the user
            double width = 0;

            // TODO Request the height of the rectangle from the user
            double height = 0;

            // Calculate area
            Rectangle rectangle = new Rectangle();
            double area = rectangle.CalculateArea(width, height);

            // TODO Generate message to the user stating the area (show appropriate message if width or height was < 0)
            Console.WriteLine("\nPlease change this message");
        }
    }
}
