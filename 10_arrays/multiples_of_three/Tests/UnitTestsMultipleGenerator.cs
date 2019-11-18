using MultiplesOfThree;
using System;
using System.Linq;
using Xunit;

namespace Tests
{
    public class UnitTestsMultipleGenerator
    {
        MultipleGenerator generator = new MultipleGenerator();

        [Fact]
        public void TestLength()
        {
            int[] multiples = generator.generate();
            Assert.Equal(10, multiples.Length);
        }

        [Fact]
        public void TestNotNull()
        {
            int[] multiples = generator.generate();
            Assert.NotNull(multiples);
        }

        [Fact]
        public void TestGeneratedValues()
        {
            int[] multiples = generator.generate();
            int[] expected = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            Assert.True(multiples.SequenceEqual(expected));
        }
    }
}
