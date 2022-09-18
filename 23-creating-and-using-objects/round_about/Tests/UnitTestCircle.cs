using RoundAbout;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestCircle
    {
        private Circle circle = new Circle();

        [Fact]
        public void TestRadius()
        {
            circle.SetRadius(123);
            Assert.Equal(123.0, circle.GetRadius(), 2);
        }

        [Fact]
        public void TestNegativeRadius()
        {
            circle.SetRadius(15);
            circle.SetRadius(-12);
            Assert.Equal(15, circle.GetRadius(), 2);
        }

        [Fact]
        public void TestDiameter()
        {
            circle.SetRadius(15);
            Assert.Equal(30, circle.GetDiameter(), 2);
        }

        [Fact]
        public void TestArea()
        {
            circle.SetRadius(15);
            Assert.Equal(706.858, circle.CalculateArea(), 2);
        }

        [Fact]
        public void TestCircumference()
        {
            circle.SetRadius(15);
            Assert.Equal(94.247, circle.CalculateCircumference(), 2);
        }
    }
}
