using StartToEnd;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestSeries
    {
        Series series = new Series();

        [Fact]
        public void TestBasicSum()
        {
            Assert.Equal(10, series.Sum(1, 5));
            Assert.Equal(10, series.Sum(0, 5));
            Assert.Equal(15, series.Sum(0, 6));
        }

        [Fact]
        public void TestBasicSumWithNegatives()
        {
            Assert.Equal(0, series.Sum(-4, 5));
            Assert.Equal(-5, series.Sum(-5, 5));
            Assert.Equal(5, series.Sum(-4, 6));
        }

        [Fact]
        public void TestBasicSumWithZeros()
        {
            Assert.Equal(0, series.Sum(0, 1));
            Assert.Equal(0, series.Sum(0, 0));
        }

        [Fact]
        public void TestSteppedSum()
        {
            Assert.Equal(16, series.Sum(1, 2, 8));
            Assert.Equal(4, series.Sum(0, 4, 5));
            Assert.Equal(15, series.Sum(0, 1, 6));
        }

        [Fact]
        public void TestSteppedSumWithNegatives()
        {
            Assert.Equal(-3, series.Sum(-4, 3, 5));
            Assert.Equal(3, series.Sum(3, 10, 4));
        }

        [Fact]
        public void TestSteppedSumWithZeros()
        {
            Assert.Equal(0, series.Sum(0, 1, 0));
        }
    }
}
