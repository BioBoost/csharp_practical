using BinaryCoding;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestBinaryConverter
    {
        private BinaryConverter converter = new BinaryConverter();

        [Fact]
        public void TestBasicBinary()
        {
            Assert.Equal(176, converter.ToDecimal("10110000"));
            Assert.Equal(176, converter.ToDecimal("1011 0000"));
            Assert.Equal(706, converter.ToDecimal("10 1100 0010"));
            Assert.Equal(0, converter.ToDecimal("0"));
            Assert.Equal(1, converter.ToDecimal("1"));
            Assert.Equal(0, converter.ToDecimal(""));
        }

        [Fact]
        public void TestCodedBinary()
        {
            Assert.Equal(176, converter.ToDecimal("b10110000"));
            Assert.Equal(5653, converter.ToDecimal("b1011000010101"));
        }
    }
}
