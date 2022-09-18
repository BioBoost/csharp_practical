using System;
using WordsEverywhere;
using Xunit;

namespace Tests
{
    public class UnitTestWordCounter
    {
        private WordCounter counter = new WordCounter();

        [Fact]
        public void TestSimpleSentence()
        {
            string hello = "Hello from the maker of this exercise.";
            Assert.Equal(7, counter.CountWords(hello));
        }

        [Fact]
        public void TestEmptyString()
        {
            string empty = "";
            Assert.Equal(0, counter.CountWords(empty));
        }

        [Fact]
        public void TestSingleWord()
        {
            string single = "Dude";
            Assert.Equal(1, counter.CountWords(single));
        }

        [Fact]
        public void TestTwoSentences()
        {
            string hal = "Hello, my name is HAL.\nI am a computer AI.";
            Assert.Equal(10, counter.CountWords(hal));
        }

        [Fact]
        public void TestMITLicenseText()
        {
            string mit = "Permission is hereby granted, free of charge, to any person obtaining a copy of" +
                " this software and associated documentation files (the \"Software\")," +
                " to deal in the Software without restriction, including without limitation the rights to use," +
                " copy, modify, merge, publish, distribute, sublicense, and or sell copies of the Software," +
                " and to permit persons to whom the Software is furnished to do so, subject to the" +
                " following conditions: The above copyright notice and this permission notice shall be" +
                " included in all copies or substantial portions of the Software.";

            Assert.Equal(87, counter.CountWords(mit));
        }
        
    }
}
