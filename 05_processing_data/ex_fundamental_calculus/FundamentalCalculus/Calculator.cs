using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalCalculus
{
    public class Calculator
    {
        public int Add(int left, int right)
        {
            // TODO: Return the sum
            return left + right;
        }

        public int Subtract(int left, int right)
        {
            // TODO: Return the difference
            return left - right;
        }

        public int Multiply(int left, int right)
        {
            // TODO: Return the product
            return left * right;
        }

        public int Divide(int left, int right)
        {
            // TODO: Return the whole divident
            return left / right;
        }

        public int Modulo(int left, int right)
        {
            // TODO: Return the modulo
            return left % right;
        }

        public int AbsoluteValue(int value)
        {
            // TODO: Return the absolute value
            return Math.Abs(value);
        }

        public int Square(int value)
        {
            // TODO: Return the squared value
            return value * value;
        }

        public int Inverse(int value)
        {
            // TODO: Return the inverse value
            // -3 => 3
            // 3 => -3
            return -value;
        }
    }
}
