using AbbreviateThis;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestAbbreviator
    {
        private Abbreviator abbreviator = new Abbreviator();

        [Fact]
        public void TestRTFM()
        {
            string rtfm = "Read The Fucking Manual";
            Assert.Equal("RTFM", abbreviator.Abbreviate(rtfm));
        }

        [Fact]
        public void TestLowercased()
        {
            string rofl = "rolling on floor laughing";
            Assert.Equal("ROFL", abbreviator.Abbreviate(rofl));
        }

        [Fact]
        public void TestSpecialCases()
        {
            string h = "hello";
            Assert.Equal("H", abbreviator.Abbreviate(h));

            string empty = "";
            Assert.Equal("", abbreviator.Abbreviate(empty));
        }
    }
}
