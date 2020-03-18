using System;
using Xunit;
using VectorFromStartToEnd;

namespace Tests
{
    public class VectorPathUnitTests
    {

        [Fact]
        public void TestResultingVectorWithoutAdd()
        {
            VectorPath path = new VectorPath();
            Vector result = path.ResultingVector();

            Assert.Equal(0, result.X(), 2);
            Assert.Equal(0, result.Y(), 2);
        }

        [Fact]
        public void TestResultingSingleVector()
        {
            VectorPath path = new VectorPath();
            path.Add(new Vector(8, -22));
            Vector result = path.ResultingVector();

            Assert.Equal(8, result.X(), 2);
            Assert.Equal(-22, result.Y(), 2);
        }

        [Fact]
        public void TestResultingTwoVectors()
        {
            VectorPath path = new VectorPath();
            path.Add(new Vector(3, 4));
            path.Add(new Vector(5, -1));
            Vector result = path.ResultingVector();

            Assert.Equal(8, result.X(), 2);
            Assert.Equal(3, result.Y(), 2);
        }

        [Fact]
        public void TestResultingFourVectors()
        {
            VectorPath path = new VectorPath();
            path.Add(new Vector(11.98, 0.63));
            path.Add(new Vector(22.63, 22.63));
            path.Add(new Vector(1.92, -0.55));
            path.Add(new Vector(-3.36, 12.56));
            Vector result = path.ResultingVector();

            Assert.Equal(33.17, result.X(), 2);
            Assert.Equal(35.27, result.Y(), 2);
        }

        [Fact]
        public void TestToString()
        {
            double x = 3;
            double y = 5;

            VectorPath path = new VectorPath();

            Vector vector = new Vector(x, y);
            path.Add(vector);
            string expected = $"[{x};{y}] with magnitude {vector.Magnitude()}\n";

            vector = new Vector(x, -y);
            path.Add(vector);
            expected += $"[{x};{-y}] with magnitude {vector.Magnitude()}\n";

            vector = new Vector(-x, -y);
            path.Add(vector);
            expected += $"[{-x};{-y}] with magnitude {vector.Magnitude()}\n";

            vector = new Vector(-x, y);
            path.Add(vector);
            expected += $"[{-x};{y}] with magnitude {vector.Magnitude()}";

            Assert.Equal(expected, path.ToString());
        }

    }
}
