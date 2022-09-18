using FundamentalCalculus;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestCalculator
    {
        Calculator uut = new Calculator();

        [Fact]
        public void TestAdd()
        {
            Assert.Equal(5, uut.Add(2, 3));
            Assert.Equal(-5, uut.Add(-2, -3));
            Assert.Equal(-1, uut.Add(2, -3));
            Assert.Equal(1, uut.Add(-2, 3));
            Assert.Equal(0, uut.Add(0, 0));
        }

        [Fact]
        public void TestSubtract()
        {
            Assert.Equal(-1, uut.Subtract(2, 3));
            Assert.Equal(1, uut.Subtract(-2, -3));
            Assert.Equal(5, uut.Subtract(2, -3));
            Assert.Equal(-5, uut.Subtract(-2, 3));
            Assert.Equal(0, uut.Subtract(0, 0));
        }

        [Fact]
        public void TestMultiply()
        {
            Assert.Equal(6, uut.Multiply(2, 3));
            Assert.Equal(6, uut.Multiply(-2, -3));
            Assert.Equal(-6, uut.Multiply(2, -3));
            Assert.Equal(-6, uut.Multiply(-2, 3));
            Assert.Equal(0, uut.Multiply(0, 2));
            Assert.Equal(0, uut.Multiply(2, 0));
            Assert.Equal(0, uut.Multiply(0, 0));
        }

        [Fact]
        public void TestDivide()
        {
            Assert.Equal(1, uut.Divide(3, 2));
            Assert.Equal(-1, uut.Divide(-3, 2));
            Assert.Equal(-1, uut.Divide(3, -2));
            Assert.Equal(1, uut.Divide(-3, -2));
        }

        [Fact]
        public void TestModulo()
        {
            Assert.Equal(1, uut.Modulo(3, 2));
            Assert.Equal(-1, uut.Modulo(-3, 2));
            Assert.Equal(1, uut.Modulo(3, -2));
            Assert.Equal(-1, uut.Modulo(-3, -2));
        }

        [Fact]
        public void TestAbsoluteValue()
        {
            Assert.Equal(3, uut.AbsoluteValue(3));
            Assert.Equal(3, uut.AbsoluteValue(-3));
            Assert.Equal(0, uut.AbsoluteValue(0));
        }

        [Fact]
        public void TestSquare()
        {
            Assert.Equal(9, uut.Square(3));
            Assert.Equal(9, uut.Square(-3));
            Assert.Equal(0, uut.Square(0));
        }

        [Fact]
        public void TestInverse()
        {
            Assert.Equal(-3, uut.Inverse(3));
            Assert.Equal(3, uut.Inverse(-3));
            Assert.Equal(0, uut.Inverse(0));
        }
    }
}
