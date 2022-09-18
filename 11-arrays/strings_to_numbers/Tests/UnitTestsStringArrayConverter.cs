using StringsToNumbers;
using System;
using System.Linq;
using Xunit;

namespace Tests
{
    public class UnitTestsStringArrayConverter
    {
        StringArrayConverter converter = new StringArrayConverter();

        [Fact]
        public void TestSimpleSet()
        {
            string[] stringValues = { "1", "2", "3", "4", "5" };
            int[] values = Array.ConvertAll(stringValues, element => Convert.ToInt32(element));

            Assert.True(values.SequenceEqual(converter.ConvertToIntegers(stringValues)));
        }

        [Fact]
        public void TestRandomSet()
        {
            Random generator = new Random();
            int[] values = new int[10];
            values.Select(element => generator.Next(-1000, 1000)).ToArray<int>();

            string[] stringValues = Array.ConvertAll(values, element => $"{element}");

            Assert.True(values.SequenceEqual(converter.ConvertToIntegers(stringValues)));
        }

        [Fact]
        public void TestEmptyArray()
        {
            string[] stringValues = { };
            int[] values = Array.ConvertAll(stringValues, element => Convert.ToInt32(element));

            Assert.True(values.SequenceEqual(converter.ConvertToIntegers(stringValues)));
        }
    }
}
