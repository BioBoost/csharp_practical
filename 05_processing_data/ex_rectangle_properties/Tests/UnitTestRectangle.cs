using RectangleProperties;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestRectangle
    {
        private double GetWidth(Rectangle rectangle)
        {
            return (double)typeof(Rectangle)
                .GetField("width", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(rectangle);
        }

        private double GetHeight(Rectangle rectangle)
        {
            return (double)typeof(Rectangle)
                .GetField("height", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(rectangle);
        }

        [Fact]
        public void TestArea()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal(GetWidth(rectangle) * GetHeight(rectangle),
                rectangle.CalculateArea());
        }

        [Fact]
        public void TestCircumference()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal(2*(GetWidth(rectangle) + GetHeight(rectangle)),
                rectangle.CalculateCircumference());
        }
    }
}
