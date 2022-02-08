using SeriesOfSquares;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestSquaredSeries
    {
        [Fact]
        public void TestSeriesSum()
        {
            Assert.Equal(14, SquaredSeries.SeriesSum(3));
            Assert.Equal(2470, SquaredSeries.SeriesSum(19));
            Assert.Equal(449735, SquaredSeries.SeriesSum(110));
            Assert.Equal(33511, SquaredSeries.SeriesSum(46));
        }

        [Fact]
        public void TestCalculateSumSeries()
        {
            Assert.Equal(14, SquaredSeries.CalculateSumSeries(3));
            Assert.Equal(16206, SquaredSeries.CalculateSumSeries(36));
            Assert.Equal(187165, SquaredSeries.CalculateSumSeries(82));
            Assert.Equal(3311, SquaredSeries.CalculateSumSeries(21));
        }
    }
}
