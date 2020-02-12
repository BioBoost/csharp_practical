using AbsoluteSum;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        private Summator summator = new Summator();

        [Fact]
        public void TestBasicSeries()
        {
            int[] values = { 1, 5, -3, 12, 0, 77, 8 };
            Assert.Equal(106, summator.Sum(values));
        }

        [Fact]
        public void TestAdvancedSeries()
        {
            int[] zeros = { 0, 0, 0, 0, 0 };
            Assert.Equal(0, summator.Sum(zeros));

            int[] empty = { };
            Assert.Equal(0, summator.Sum(empty));

            int[] negatives = { -1, -1, -1, -1, -1 };
            Assert.Equal(5, summator.Sum(negatives));
        }
    }
}
