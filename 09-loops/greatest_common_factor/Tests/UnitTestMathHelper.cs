using GreatestCommonFactor;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestMathHelper
    {
        private MathHelper helper = new MathHelper();

        [Fact]
        public void TestHighestCommonFactorPositiveValues()
        {
            Assert.Equal(3, helper.DetermineGreatestCommonFactor(9, 12));
            Assert.Equal(6, helper.DetermineGreatestCommonFactor(6, 18));
            Assert.Equal(12, helper.DetermineGreatestCommonFactor(24, 108));
            Assert.Equal(4, helper.DetermineGreatestCommonFactor(8532, 232));
            Assert.Equal(36, helper.DetermineGreatestCommonFactor(8532, 2232));
        }

        [Fact]
        public void TestHighestCommonFactorNegativeValues()
        {
            Assert.Equal(3, helper.DetermineGreatestCommonFactor(-9, 12));
            Assert.Equal(6, helper.DetermineGreatestCommonFactor(6, -18));
            Assert.Equal(12, helper.DetermineGreatestCommonFactor(-24, -108));
            Assert.Equal(4, helper.DetermineGreatestCommonFactor(-8532, 232));
            Assert.Equal(36, helper.DetermineGreatestCommonFactor(8532, -2232));
        }

        [Fact]
        public void TestHighestCommonFactorZeroValues()
        {
            Assert.Equal(12, helper.DetermineGreatestCommonFactor(0, 12));
            Assert.Equal(18, helper.DetermineGreatestCommonFactor(0, -18));
            Assert.Equal(0, helper.DetermineGreatestCommonFactor(0, 0));
            Assert.Equal(8532, helper.DetermineGreatestCommonFactor(-8532, 0));
            Assert.Equal(8532, helper.DetermineGreatestCommonFactor(8532, 0));
        }
    }
}
