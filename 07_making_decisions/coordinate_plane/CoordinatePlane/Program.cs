using System;

namespace CoordinatePlane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Coordinate Plane App");

            // TODO Request point coordinates from user

            // Create point
            Point point = new Point();
            point.X = 0;        // Set user value
            point.Y = 0;        // Set user value

            // TODO Output in which quadrant the point lies
            // Warning! Output different message if it lies in the origin
            string quadrant = point.Quadrant();

        }
    }
}
