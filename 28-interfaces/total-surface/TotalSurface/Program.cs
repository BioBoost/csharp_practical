using System;

namespace TotalSurface
{
    class Program
    {
        static int RequestAction() {
            int action = 0;
            do {
                Console.WriteLine("What shape would you like to create ?");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Square");
                Console.WriteLine("0. Exit");
                action = Convert.ToInt32(Console.ReadLine());
            } while (action < 0 || action > 2);

            return action;
        }

        static Circle CreateCircle() {
            Console.Write("Please enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius);
            return circle;
        }

        static Square CreateSquare() {
            Console.Write("Please enter side of square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Square square = new Square(side);
            return square;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Total Surface.");
            Console.WriteLine();

            AreaListing listing = new AreaListing();

            int action = 0;
            do {
                action = RequestAction();

                if (action == 1) {
                    Circle circle = CreateCircle();
                    listing.Add(circle);

                    Console.WriteLine();
                    Console.WriteLine("You current surface listing:");
                    Console.WriteLine(listing);
                    Console.WriteLine();
                } else if (action == 2) {
                    Square square = CreateSquare();
                    listing.Add(square);

                    Console.WriteLine();
                    Console.WriteLine("You current surface listing:");
                    Console.WriteLine(listing);
                    Console.WriteLine();
                } else {
                    Console.WriteLine("Thank you for using our app.");
                }

            } while (action != 0);

        }
    }
}
