using Palindrome;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestPalindromeChecker
    {
        private PalindromeChecker checker = new PalindromeChecker();

        [Fact]
        public void TestPalindrome()
        {
            Assert.True(checker.IsPalindrome("racecar"));
        }

        [Fact]
        public void TestNonePalindrome()
        {
            Assert.False(checker.IsPalindrome("house"));
        }

        [Fact]
        public void TestCapitalLetters()
        {
            Assert.True(checker.IsPalindrome("RaceCar"));
            Assert.False(checker.IsPalindrome("HouSe"));
        }

        [Fact]
        public void TestEmptyString()
        {
            Assert.False(checker.IsPalindrome(""));
        }

        [Fact]
        public void TestUntrimmedWord()
        {
            Assert.True(checker.IsPalindrome("racecar "));
            Assert.True(checker.IsPalindrome(" racecar"));
            Assert.True(checker.IsPalindrome(" racecar "));
            Assert.False(checker.IsPalindrome(" house"));
            Assert.False(checker.IsPalindrome("house "));
            Assert.False(checker.IsPalindrome(" house "));
        }
    }
}
