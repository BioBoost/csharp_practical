using System;
using TextProperties;
using Xunit;

namespace Tests
{
    public class UnitTestStringAnalyzer
    {
        private StringAnalyzer analyzer = new StringAnalyzer();

        [Fact]
        public void TestNumberOfVowels()
        {
            Assert.Equal(0, analyzer.NumberOfVowels("qwrtypsdfghjklzxcvbnm"));
            Assert.Equal(0, analyzer.NumberOfVowels("QWRTYPSDFGHJKLZXCVBNM"));
            Assert.Equal(0, analyzer.NumberOfVowels("1234567890"));
            Assert.Equal(0, analyzer.NumberOfVowels("!@#$%^&*()_+"));
            Assert.Equal(0, analyzer.NumberOfVowels(" \n \t\n\t\r\n\r\t "));
            Assert.Equal(5, analyzer.NumberOfVowels("euioa"));
            Assert.Equal(5, analyzer.NumberOfVowels("EUIOA"));
            Assert.Equal(7, analyzer.NumberOfVowels("Ah For Crying Out Loud"));
            Assert.Equal(8, analyzer.NumberOfVowels("99 bottles of beer on the wall"));
        }

        [Fact]
        public void TestNumberOfConsonants()
        {
            Assert.Equal(21, analyzer.NumberOfConsonants("qwrtypsdfghjklzxcvbnm"));
            Assert.Equal(21, analyzer.NumberOfConsonants("QWRTYPSDFGHJKLZXCVBNM"));
            Assert.Equal(0, analyzer.NumberOfConsonants("1234567890"));
            Assert.Equal(0, analyzer.NumberOfConsonants("!@#$%^&*()_+"));
            Assert.Equal(0, analyzer.NumberOfConsonants(" \n \t\n\t\r\n\r\t "));
            Assert.Equal(0, analyzer.NumberOfConsonants("euioa"));
            Assert.Equal(0, analyzer.NumberOfConsonants("EUIOA"));
            Assert.Equal(11, analyzer.NumberOfConsonants("Ah For Crying Out Loud"));
            Assert.Equal(14, analyzer.NumberOfConsonants("99 bottles of beer on the wall"));
        }

        [Fact]
        public void TestNumberOfDigits()
        {
            Assert.Equal(0, analyzer.NumberOfDigits("qwrtypsdfghjklzxcvbnm"));
            Assert.Equal(0, analyzer.NumberOfDigits("QWRTYPSDFGHJKLZXCVBNM"));
            Assert.Equal(10, analyzer.NumberOfDigits("1234567890"));
            Assert.Equal(0, analyzer.NumberOfDigits("!@#$%^&*()_+"));
            Assert.Equal(0, analyzer.NumberOfDigits(" \n \t\n\t\r\n\r\t "));
            Assert.Equal(0, analyzer.NumberOfDigits("euioa"));
            Assert.Equal(0, analyzer.NumberOfDigits("EUIOA"));
            Assert.Equal(0, analyzer.NumberOfDigits("Ah For Crying Out Loud"));
            Assert.Equal(2, analyzer.NumberOfDigits("99 bottles of beer on the wall"));
        }

        [Fact]
        public void TestNumberOfUppercaseLetters()
        {
            Assert.Equal(0, analyzer.NumberOfUppercaseLetters("qwrtypsdfghjklzxcvbnm"));
            Assert.Equal(21, analyzer.NumberOfUppercaseLetters("QWRTYPSDFGHJKLZXCVBNM"));
            Assert.Equal(0, analyzer.NumberOfUppercaseLetters("1234567890"));
            Assert.Equal(0, analyzer.NumberOfUppercaseLetters("!@#$%^&*()_+"));
            Assert.Equal(0, analyzer.NumberOfUppercaseLetters(" \n \t\n\t\r\n\r\t "));
            Assert.Equal(0, analyzer.NumberOfUppercaseLetters("euioa"));
            Assert.Equal(5, analyzer.NumberOfUppercaseLetters("EUIOA"));
            Assert.Equal(5, analyzer.NumberOfUppercaseLetters("Ah For Crying Out Loud"));
            Assert.Equal(0, analyzer.NumberOfUppercaseLetters("99 bottles of beer on the wall"));
        }

        [Fact]
        public void TestNumberOfLowercaseLetters()
        {
            Assert.Equal(21, analyzer.NumberOfLowercaseLetters("qwrtypsdfghjklzxcvbnm"));
            Assert.Equal(0, analyzer.NumberOfLowercaseLetters("QWRTYPSDFGHJKLZXCVBNM"));
            Assert.Equal(0, analyzer.NumberOfLowercaseLetters("1234567890"));
            Assert.Equal(0, analyzer.NumberOfLowercaseLetters("!@#$%^&*()_+"));
            Assert.Equal(0, analyzer.NumberOfLowercaseLetters(" \n \t\n\t\r\n\r\t "));
            Assert.Equal(5, analyzer.NumberOfLowercaseLetters("euioa"));
            Assert.Equal(0, analyzer.NumberOfLowercaseLetters("EUIOA"));
            Assert.Equal(13, analyzer.NumberOfLowercaseLetters("Ah For Crying Out Loud"));
            Assert.Equal(22, analyzer.NumberOfLowercaseLetters("99 bottles of beer on the wall"));
        }

        [Fact]
        public void TestNumberOfWhitespaceCharacters()
        {
            Assert.Equal(0, analyzer.NumberOfWhitespaceCharacters("qwrtypsdfghjklzxcvbnm"));
            Assert.Equal(0, analyzer.NumberOfWhitespaceCharacters("QWRTYPSDFGHJKLZXCVBNM"));
            Assert.Equal(0, analyzer.NumberOfWhitespaceCharacters("1234567890"));
            Assert.Equal(0, analyzer.NumberOfWhitespaceCharacters("!@#$%^&*()_+"));
            Assert.Equal(11, analyzer.NumberOfWhitespaceCharacters(" \n \t\n\t\r\n\r\t "));
            Assert.Equal(0, analyzer.NumberOfWhitespaceCharacters("euioa"));
            Assert.Equal(0, analyzer.NumberOfWhitespaceCharacters("EUIOA"));
            Assert.Equal(4, analyzer.NumberOfWhitespaceCharacters("Ah For Crying Out Loud"));
            Assert.Equal(6, analyzer.NumberOfWhitespaceCharacters("99 bottles of beer on the wall"));
        }
    }
}
