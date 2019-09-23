using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProperties
{
    public class Rectangle
    {
        public double CalculateArea()
        {
            double width = 3;
            double height = 8;

            // TODO: Calculate the area of a rectangle
            double area = 0;

            Console.WriteLine("The rectangle has an area of " + area
                + "sq centimeters.");

            // Please dont change the code below (automatic unit tests)
            return area;
        }

        public double CalculateCircumference()
        {
            double width = 3;
            double height = 8;

            // TODO: Calculate the circumference of a rectangle
            double circumference = 0;

            Console.WriteLine("The rectangle has an circumference of " + circumference
                + " centimeters.");

            // Please dont change the code below (automatic unit tests)
            return circumference;
        }
    }
}
