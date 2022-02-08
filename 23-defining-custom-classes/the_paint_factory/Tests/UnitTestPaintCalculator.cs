using System;
using ThePaintFactory;
using Xunit;

namespace Tests
{
    public class UnitTestPaintCalculator
    {
        private PaintCalculator calculator = new PaintCalculator();

        [Fact]
        public void TestSquareArea()
        {
            calculator.AddSquare(5);
            Assert.Equal(25, calculator.TotalArea, 2);

            calculator.AddSquare(8);
            Assert.Equal((25 + 64), calculator.TotalArea, 2);

            calculator.AddSquare(2);
            Assert.Equal((25 + 64 + 4), calculator.TotalArea, 2);

            calculator.AddSquare(2.5);
            Assert.Equal((25 + 64 + 4 + 6.25), calculator.TotalArea, 2);
        }

        [Fact]
        public void TestRectangleArea()
        {
            calculator.AddRectangle(5, 3);
            Assert.Equal(15, calculator.TotalArea, 2);

            calculator.AddRectangle(1, 1);
            Assert.Equal((15 + 1), calculator.TotalArea, 2);

            calculator.AddRectangle(4, 9);
            Assert.Equal((15 + 1 + 36), calculator.TotalArea, 2);

            calculator.AddRectangle(3.2, 4.8);
            Assert.Equal((15 + 1 + 36 + 15.36), calculator.TotalArea, 2);
        }

        [Fact]
        public void TestLitersSingleCoat()
        {
            calculator.AddRectangle(1, 3);
            calculator.AddSquare(3);
            Assert.Equal(2, calculator.LitersOfPaint(1), 2);
        }

        [Fact]
        public void TestLitersMultipleCoats()
        {
            calculator.AddRectangle(1, 3);
            calculator.AddSquare(3);
            calculator.AddRectangle(3, 4);
            Assert.Equal(7, calculator.LitersOfPaint(3), 2);
        }

        [Fact]
        public void TestLitersComplexerAreas()
        {
            calculator.AddRectangle(3.4, 6.8);
            calculator.AddSquare(2.9);
            calculator.AddRectangle(3.3, 8.5);
            Assert.Equal(16, calculator.LitersOfPaint(3), 2);

            calculator.AddRectangle(2, 4.5);
            calculator.AddSquare(5);
            calculator.AddRectangle(3.5, 4.45);
            calculator.AddSquare(3);
            Assert.Equal(21, calculator.LitersOfPaint(2), 2);
        }

    }
}
