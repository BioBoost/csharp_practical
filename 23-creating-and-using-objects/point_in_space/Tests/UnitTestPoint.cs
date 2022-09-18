using PointInSpace;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestPoint
    {
        private Point point = new Point();

        [Fact]
        public void TestDefaultValues()
        {
            Assert.Equal(0, point.GetX());
            Assert.Equal(0, point.GetY());
        }

        [Fact]
        public void TestX()
        {
            point.SetX(13);
            Assert.Equal(13, point.GetX());
            Assert.Equal(0, point.GetY());      // Setting X should not change Y
        }

        [Fact]
        public void TestY()
        {
            point.SetY(88);
            Assert.Equal(88, point.GetY());
            Assert.Equal(0, point.GetX());      // Setting Y should not change X
        }

        [Fact]
        public void TestToString()
        {
            point.SetX(15);
            point.SetY(22);
            Assert.Equal("[15,22]", point.ToString());
        }
    }
}
