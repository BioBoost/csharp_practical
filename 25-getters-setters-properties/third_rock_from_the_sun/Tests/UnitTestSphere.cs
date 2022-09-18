using System;
using ThirdRockFromTheSun;
using Xunit;

namespace Tests
{
    public class UnitTestSphere
    {
        private Sphere sphere = new Sphere();

        [Fact]
        public void TestHasPropertyRadius()
        {

            Assert.NotNull(sphere.GetType().GetProperty("Radius"));
        }

        [Fact]
        public void TestRadiusProperty()
        {
            sphere.Radius = 12.3;
            Assert.Equal(12.3, sphere.Radius, 2);
        }

        [Fact]
        public void TestRadiusNotNegative()
        {
            sphere.Radius = -542.4;
            Assert.Equal(542.4, sphere.Radius, 2);
        }

        [Fact]
        public void TestHasPropertyDiameter()
        {

            Assert.NotNull(sphere.GetType().GetProperty("Diameter"));
        }

        [Fact]
        public void TestDiameterProperty()
        {
            sphere.Diameter = 55.1;
            Assert.Equal(55.1, sphere.Diameter, 2);
        }

        [Fact]
        public void TestDiameterNotNegative()
        {
            sphere.Diameter = -3655;
            Assert.Equal(3655, sphere.Diameter, 2);
        }

        [Fact]
        public void TestRadiusDiameterRelation()
        {
            sphere.Diameter = 88;
            Assert.Equal(44, sphere.Radius, 2);

            sphere.Radius = 12;
            Assert.Equal(24, sphere.Diameter, 2);
        }

        [Fact]
        public void TestSurface()
        {
            sphere.Radius = 3;
            Assert.Equal(113.10, sphere.Surface(), 2);

            sphere.Radius = 77;
            Assert.Equal(74506.01, sphere.Surface(), 2);

            sphere.Radius = 6453;
            Assert.Equal(523278865.12, sphere.Surface(), 2);

            sphere.Radius = 1;
            Assert.Equal(12.57, sphere.Surface(), 2);
        }

        [Fact]
        public void TestVolume()
        {
            sphere.Radius = 3;
            Assert.Equal(113.10, sphere.Volume(), 2);

            sphere.Radius = 108;
            Assert.Equal(5276669.29, sphere.Volume(), 2);

            sphere.Radius = 6524;
            Assert.Equal(1163135916189.84, sphere.Volume(), 2);

            sphere.Radius = 1;
            Assert.Equal(4.19, sphere.Volume(), 2);
        }

    }
}
