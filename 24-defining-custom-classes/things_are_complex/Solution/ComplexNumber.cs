using System;
using System.Collections.Generic;
using System.Text;

namespace ThingsAreComplex
{
    public class ComplexNumber
    {
        // Constructors
        public ComplexNumber()
        {
        }

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        // Getters
        public double Real()
        {
            return real;
        }

        public double Imaginary()
        {
            return imaginary;
        }

        // Other methods
        public double Magnitude()
        {
            return Math.Sqrt(real*real + imaginary*imaginary);
        }

        public ComplexNumber Add(ComplexNumber value)
        {
            return new ComplexNumber(
                    this.real + value.real,
                    this.imaginary + value.imaginary
                );
        }

        public ComplexNumber Subtract(ComplexNumber value)
        {
            // OPTION 1
            return new ComplexNumber(
                    this.real - value.real,
                    this.imaginary - value.imaginary
                );

            // OPTION 2 - Subtract = inverse of Add
            // return this.Add(new ComplexNumber(-value.real, -value.imaginary));
        }

        public ComplexNumber Multiply(ComplexNumber value)
        {
            return new ComplexNumber(
                    (this.real * value.real) - (this.imaginary * value.imaginary),
                    (this.real * value.imaginary) + (this.imaginary * value.real)
                );
        }

        public ComplexNumber Divide(ComplexNumber value)
        {
            // OPTION 1
            return new ComplexNumber(
                    (1 / value.SquaredMagnitude()) * ((this.real * value.real) + (this.imaginary * value.imaginary)),
                    (1 / value.SquaredMagnitude()) * ((this.imaginary * value.real) - (this.real * value.imaginary))
                );

            // OPTION 2 - Using multiplication and reciprocal (see Wikipedia)
            // return this.Multiply(value.Reciprocal());
        }

        // Added this method to make code more DRY
        // Private because not needed outside of this class
        private double SquaredMagnitude()
        {
            return this.Magnitude() * this.Magnitude();
        }

        // Added this method to make OPTION 2 of Divide cleaner
        // Also adds usefull public method: reciprocal = 1/z
        public ComplexNumber Reciprocal()
        {
            return new ComplexNumber(
                    this.real / this.SquaredMagnitude(),
                    - this.imaginary / this.SquaredMagnitude()
                );
        }

        public override string ToString()
        {
            if (this.imaginary > 0)
            {
                return $"({this.real} + {this.imaginary}i)";
            }
            else
            {
                return $"({this.real} - {Math.Abs(this.imaginary)}i)";
            }
        }

        // Attributes
        private double real = 0;
        private double imaginary = 0;
    }
}
