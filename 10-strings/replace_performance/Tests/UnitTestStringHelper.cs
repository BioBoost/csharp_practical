using ReplacePerformance;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestStringHelper
    {
        private StringHelper helper = new StringHelper();

        [Fact]
        public void TestLibraryReplaceSingleOccurence()
        {
            Assert.Equal("Hello World", helper.ReplaceUsingLibrary("Hello Universe", "Universe", "World"));
        }

        [Fact]
        public void TestLibraryReplaceMultipleOccurences()
        {
            string expected = "if a string function return a string, the original string remains unchanged and a new string is instance is returned";
            string original = "if a sting function return a sting, the original sting remains unchanged and a new sting is instance is returned";
            Assert.Equal(expected, helper.ReplaceUsingLibrary(original, "sting", "string"));
        }

        [Fact]
        public void TestOwnReplaceSingleOccurence()
        {
            Assert.Equal("Hello World", helper.ReplaceUsingOwnImplementation("Hello Universe", "Universe", "World"));
        }

        [Fact]
        public void TestOwnReplaceMultipleOccurences()
        {
            string expected = "if a string function return a string, the original string remains unchanged and a new string is instance is returned";
            string original = "if a sting function return a sting, the original sting remains unchanged and a new sting is instance is returned";
            Assert.Equal(expected, helper.ReplaceUsingOwnImplementation(original, "sting", "string"));
        }

        [Fact]
        public void TestOwnReplaceBeginningOfSentence()
        {
            Assert.Equal("Bye Universe", helper.ReplaceUsingOwnImplementation("Hello Universe", "Hello", "Bye"));
        }
    }
}
