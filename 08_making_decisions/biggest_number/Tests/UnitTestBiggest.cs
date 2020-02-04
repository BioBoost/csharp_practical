using BiggestNumber;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestBiggest
    {
        Biggest uut = new Biggest();

        [Fact]
        public void TestDifferentValues()
        {
            Assert.Equal(32, uut.DetermineBiggest(32, 12, 23));
            Assert.Equal(103, uut.DetermineBiggest(99, 103, 16));
            Assert.Equal(43, uut.DetermineBiggest(11, 12, 43));
        }

        [Fact]
        public void TestSameValues()
        {
            Assert.Equal(8, uut.DetermineBiggest(8, 8, 8));
            Assert.Equal(0, uut.DetermineBiggest(0, 0, 0));
        }

        [Fact]
        public void TestWithZero()
        {
            Assert.Equal(23, uut.DetermineBiggest(0, 12, 23));
            Assert.Equal(99, uut.DetermineBiggest(99, 0, 16));
            Assert.Equal(12, uut.DetermineBiggest(11, 12, 0));
        }

        [Fact]
        public void TestWithNegative()
        {
            Assert.Equal(105, uut.DetermineBiggest(-3, 13, 105));
            Assert.Equal(0, uut.DetermineBiggest(0, 0, -16));
            Assert.Equal(-12, uut.DetermineBiggest(-511, -12, -77));
        }
    }
}
