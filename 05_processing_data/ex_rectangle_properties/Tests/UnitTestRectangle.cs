using RectangleProperties;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestRectangle
    {
        [Fact]
        public void TestArea()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal(24, rectangle.CalculateArea());
        }

        [Fact]
        public void TestCircumference()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal(22, rectangle.CalculateCircumference());
        }
    }
}
