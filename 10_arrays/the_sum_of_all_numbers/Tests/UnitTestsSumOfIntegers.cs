using System;
using System.Collections.Generic;
using System.Linq;
using TheSumOfAllNumbers;
using Xunit;

namespace Tests
{
    public class UnitTestsSumOfIntegers
    {
        SumOfIntegers summator = new SumOfIntegers();

        [Fact]
        public void TestEasySet()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int expected = values.Sum();

            int sum = summator.CalculateSum(values);
            Assert.Equal(expected, sum);
        }

        [Fact]
        public void TestRandomSet()
        {
            Random generator = new Random();
            int[] values = new int[10];
            values = values.Select(element => generator.Next(-1000, 1000)).ToArray<int>();

            int expected = values.Sum();
            int sum = summator.CalculateSum(values);
            Assert.Equal(expected, sum);
        }

        [Fact]
        public void TestEmptyArray()
        {
            int[] values = { };
            int sum = summator.CalculateSum(values);
            Assert.Equal(0, sum);
        }
    }
}
