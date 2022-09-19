using HowManyTimes;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestStringFinder
    {
        private StringFinder finder = new StringFinder();

        [Fact]
        public void TestSingleOccurrence()
        {
            string text = "Hello World from Belgium.";
            Assert.Equal(1, finder.SearchAndCount(text, "from"));
            Assert.Equal(1, finder.SearchAndCount(text, "Belgium"));
        }

        [Fact]
        public void TestNoOccurrence()
        {
            string text = "Hello World from Belgium. The Life of Brain is good.";
            Assert.Equal(0, finder.SearchAndCount(text, "Dude"));
        }

        [Fact]
        public void TestLowerCaseUpperCase()
        {
            string text = "Hello World From Belgium. The Life of Brain is good.";
            Assert.Equal(1, finder.SearchAndCount(text, "FROM"));
            Assert.Equal(1, finder.SearchAndCount(text, "from"));
            Assert.Equal(1, finder.SearchAndCount(text, "FrOm"));
            Assert.Equal(1, finder.SearchAndCount(text, "brain"));
            Assert.Equal(1, finder.SearchAndCount(text, "Is"));
        }

        [Fact]
        public void TestMultipleOccurrence()
        {
            string text = "Hello World from Belgium is the place to start. This is C# from VIVES. Hope you are ready for this. I sure am. From Belgium with Love.";
            Assert.Equal(3, finder.SearchAndCount(text, "from"));
            Assert.Equal(2, finder.SearchAndCount(text, "is"));
            Assert.Equal(2, finder.SearchAndCount(text, "belgium"));
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

        [Fact]
        public void TestAllEmpty()
        {
            string text = "";
            Assert.Equal(0, finder.SearchAndCount(text, ""));
        }
    }
}
