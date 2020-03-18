using System;
using Xunit;
using VectorFromStartToEnd;

namespace Tests
{
    public class VectorUnitTests
    {
        [Fact]
        public void TestDefaultConstructor()
        {
            Vector vector = new Vector();
            Assert.Equal(0.0, vector.X(), 2);
            Assert.Equal(0.0, vector.Y(), 2);
        }

        [Fact]
        public void TestInitializationContructor()
        {
            Vector vector = new Vector(12, -23.23);
            Assert.Equal(12.0, vector.X(), 2);
            Assert.Equal(-23.23, vector.Y(), 2);
        }

        [Fact]
        public void TestMagnitude()
        {
            Vector vector = new Vector(3, 4);
            Assert.Equal(5.0, vector.Magnitude(), 2);

            vector = new Vector(3, -4);
            Assert.Equal(5.0, vector.Magnitude(), 2);
        }

        [Fact]
        public void TestToString()
        {
            double x = 3;
            double y = 5;

            Vector vector = new Vector(x, y);
            string expected = $"[{x};{y}] with magnitude {vector.Magnitude()}";
            Assert.Equal(expected, vector.ToString());

            vector = new Vector(x, -y);
            expected = $"[{x};{-y}] with magnitude {vector.Magnitude()}";
            Assert.Equal(expected, vector.ToString());

            vector = new Vector(-x, -y);
            expected = $"[{-x};{-y}] with magnitude {vector.Magnitude()}";
            Assert.Equal(expected, vector.ToString());

            vector = new Vector(-x, y);
            expected = $"[{-x};{y}] with magnitude {vector.Magnitude()}";
            Assert.Equal(expected, vector.ToString());
        }
    }
}
