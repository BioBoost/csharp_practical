using ParallelArrays;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestArrayHelper
    {
        [Fact]
        public void TestCountDifferentFrom()
        {
            Assert.Equal(3, ArrayHelper.CountDifferentFrom(new int[] { 13, 2, 22, 12 }, 12));
            Assert.Equal(1, ArrayHelper.CountDifferentFrom(new int[] { 0, 33, 0, 0 }, 0));
            Assert.Equal(0, ArrayHelper.CountDifferentFrom(new int[] { 0, 0, 0 }, 0));
            Assert.Equal(3, ArrayHelper.CountDifferentFrom(new int[] { 1, 5, 88 }, 0));
        }

        [Fact]
        public void TestSumByElements()
        {
            Assert.Equal(new int[] { 1, 2, 3, 4 }, ArrayHelper.SumByElements(
                new int[] { 1, 1, 1, 1 },
                new int[] { 0, 1, 2, 3 }
            ));

            Assert.Equal(new int[] { 0, -1, 88, 23 }, ArrayHelper.SumByElements(
                new int[] { 32, 5, -5, 0 },
                new int[] { -32, -6, 93, 23 }
            ));

            Assert.Equal(new int[] { 0, 0 }, ArrayHelper.SumByElements(
                new int[] { 0, -123 },
                new int[] { 0, 123 }
            ));

            Assert.Equal(new int[] { 16, 12, 40, 110, 0, 33 }, ArrayHelper.SumByElements(
                new int[] { 0, 12, 40, 55, 0, 0 },
                new int[] { 16, 0, 0, 55, 0, 33 }
            ));
        }

        [Fact]
        public void TestDoubleInSize()
        {
            Assert.Equal(16, ArrayHelper.DoubleInSize(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }).Length);

            Assert.Equal(new int[] { 0, -1, 0, 0 }, ArrayHelper.DoubleInSize(
                new int[] { 0, -1 }
            ));

            Assert.Equal(new int[] { 15, 11, 3, 0, 0, 0, 0, 0 }, ArrayHelper.DoubleInSize(
                new int[] { 15, 11, 3, 0 }
            ));
        }
    }
}
