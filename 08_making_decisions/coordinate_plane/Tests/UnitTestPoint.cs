using CoordinatePlane;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestPoint
    {
        Point point = new Point();

        [Fact]
        public void TestFirstQuadrant()
        {
            point.X = 23;
            point.Y = 89;
            Assert.Equal("first", point.Quadrant());
        }

        [Fact]
        public void TestSecondQuadrant()
        {
            point.X = -23;
            point.Y = 89;
            Assert.Equal("second", point.Quadrant());
        }

        [Fact]
        public void TestThirdQuadrant()
        {
            point.X = -23;
            point.Y = -89;
            Assert.Equal("third", point.Quadrant());
        }

        [Fact]
        public void TestFourthQuadrant()
        {
            point.X = 23;
            point.Y = -89;
            Assert.Equal("fourth", point.Quadrant());
        }

        [Fact]
        public void TestOrigin()
        {
            point.X = 0;
            point.Y = 0;
            Assert.Equal("origin", point.Quadrant());
        }
    }
}
