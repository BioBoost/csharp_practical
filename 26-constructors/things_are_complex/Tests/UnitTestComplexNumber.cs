using System;
using ThingsAreComplex;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestDefaultConstructor()
        {
            ComplexNumber complex = new ComplexNumber();
            Assert.Equal(0.0, complex.Real(), 2);
            Assert.Equal(0.0, complex.Imaginary(), 2);
        }

        [Fact]
        public void TestInitializationContructor()
        {
            ComplexNumber complex = new ComplexNumber(12, -23.23);
            Assert.Equal(12.0, complex.Real(), 2);
            Assert.Equal(-23.23, complex.Imaginary(), 2);
        }

        [Fact]
        public void TestMagnitude()
        {
            ComplexNumber complex = new ComplexNumber(3, 4);
            Assert.Equal(5.0, complex.Magnitude(), 2);

            complex = new ComplexNumber(3, -4);
            Assert.Equal(5.0, complex.Magnitude(), 2);
        }

        [Fact]
        public void TestAdd()
        {
            ComplexNumber left = new ComplexNumber(-4, 7);
            ComplexNumber right = new ComplexNumber(5, -10);
            ComplexNumber expected = new ComplexNumber(1, -3);
            ComplexNumber actual = left.Add(right);

            Assert.Equal(expected.Real(), actual.Real(), 2);
            Assert.Equal(expected.Imaginary(), actual.Imaginary(), 2);
        }

        [Fact]
        public void TestSubtract()
        {
            ComplexNumber left = new ComplexNumber(4, 12);
            ComplexNumber right = new ComplexNumber(3, -15);
            ComplexNumber expected = new ComplexNumber(1, 27);
            ComplexNumber actual = left.Subtract(right);

            Assert.Equal(expected.Real(), actual.Real(), 2);
            Assert.Equal(expected.Imaginary(), actual.Imaginary(), 2);
        }

        [Fact]
        public void TestMultiply()
        {
            ComplexNumber left = new ComplexNumber(1, -5);
            ComplexNumber right = new ComplexNumber(-9, 2);
            ComplexNumber expected = new ComplexNumber(1, 47);
            ComplexNumber actual = left.Multiply(right);

            Assert.Equal(expected.Real(), actual.Real(), 2);
            Assert.Equal(expected.Imaginary(), actual.Imaginary(), 2);
        }

        [Fact]
        public void TestDivision()
        {
            ComplexNumber left = new ComplexNumber(6, -9);
            ComplexNumber right = new ComplexNumber(0, 2);
            ComplexNumber expected = new ComplexNumber(-4.5, -3);
            ComplexNumber actual = left.Divide(right);

            Assert.Equal(expected.Real(), actual.Real(), 2);
            Assert.Equal(expected.Imaginary(), actual.Imaginary(), 2);
        }

        [Fact]
        public void TestAnotherDivision()
        {
            ComplexNumber left = new ComplexNumber(3, -1);
            ComplexNumber right = new ComplexNumber(2, 7);
            ComplexNumber expected = new ComplexNumber(-1.0 / 53, -23.0 / 53);
            ComplexNumber actual = left.Divide(right);

            Assert.Equal(expected.Real(), actual.Real(), 2);
            Assert.Equal(expected.Imaginary(), actual.Imaginary(), 2);
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("(3 + 5i)", new ComplexNumber(3, 5).ToString());
            Assert.Equal("(3 - 5i)", new ComplexNumber(3, -5).ToString());
            Assert.Equal("(-3 + 5i)", new ComplexNumber(-3, 5).ToString());
            Assert.Equal("(-3 - 5i)", new ComplexNumber(-3, -5).ToString());
        }
    }
}
