using Reversal;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestStringReverser
    {
        private StringReverser reverser = new StringReverser();

        private string reverse(string original)
        {
            char[] chars = original.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }

        [Fact]
        public void TestReverse()
        {
            string text = "saito";
            Assert.Equal(this.reverse(text), reverser.Reverse(text));
        }

        [Fact]
        public void TestReverseWithCapital()
        {
            string text = "Saito";
            Assert.Equal(this.reverse(text), reverser.Reverse(text));
        }

        [Fact]
        public void TestReverseTwoWords()
        {
            string text = "Hello World";
            Assert.Equal(this.reverse(text), reverser.Reverse(text));
        }
    }
}
