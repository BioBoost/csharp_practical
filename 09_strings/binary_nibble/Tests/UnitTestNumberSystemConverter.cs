using BinaryNibble;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestNumberSystemConverter
    {
        private NumberSystemConverter converter = new NumberSystemConverter();

        [Fact]
        public void TestLargeDecimal()
        {
            Assert.Equal("1111 0100", converter.DecimalToBinary(244));
        }

        [Fact]
        public void TestSmallDecimal()
        {
            Assert.Equal("0000 1100", converter.DecimalToBinary(12));
        }

        [Fact]
        public void TestPositiveDecimalWithPadding()
        {
            Assert.Equal("0111 1011", converter.DecimalToBinary(123));
        }

        [Fact]
        public void TestZeroDecimal()
        {
            Assert.Equal("0000 0000", converter.DecimalToBinary(0));
        }

    }
}
