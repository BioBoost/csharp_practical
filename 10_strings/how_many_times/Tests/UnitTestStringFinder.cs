using HowManyTimes;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestStringFinder
    {
        private StringFinder finder = new StringFinder();

        [Fact]
        public void TestSingleOccurence()
        {
            string text = "Hello World from Belgium.";
            Assert.Equal(1, finder.SearchAndCount(text, "from"));
        }

        [Fact]
        public void TestNoOccurence()
        {
            string text = "Hello World from Belgium.";
            Assert.Equal(0, finder.SearchAndCount(text, "Dude"));
        }

        [Fact]
        public void TestLowerCaseUpperCase()
        {
            string text = "Hello World From Belgium.";
            Assert.Equal(1, finder.SearchAndCount(text, "FROM"));
            Assert.Equal(1, finder.SearchAndCount(text, "from"));
            Assert.Equal(1, finder.SearchAndCount(text, "FrOm"));
        }

        [Fact]
        public void TestMultipleOccurence()
        {
            string text = "Hello World from Belgium. This is C# from VIVES. Hope you are ready. I sure am. From Russia with Love.";
            Assert.Equal(3, finder.SearchAndCount(text, "from"));
        }

        [Fact]
        public void TestEmptyText()
        {
            string text = "";
            Assert.Equal(0, finder.SearchAndCount(text, "Dude"));
        }

        [Fact]
        public void TestEmptyWord()
        {
            string text = "Hello World from Belgium.";
            Assert.Equal(0, finder.SearchAndCount(text, ""));
        }
    }
}
