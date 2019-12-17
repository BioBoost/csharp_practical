using HoloGram;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestPangramChecker
    {
        private PangramChecker checker = new PangramChecker();

        [Fact]
        public void TestIsPangram()
        {
            Assert.True(checker.IsPangram("Op brute wijze ving de schooljuf de quasi kalme lynx"));
            Assert.True(checker.IsPangram("The quick brown fox jumps over the lazy dog"));
            Assert.False(checker.IsPangram("Dude dit is totaal geen Pangram"));
            Assert.False(checker.IsPangram(""));
        }
    }
}
