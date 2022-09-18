using FrameDelimiter;
using System;
using Xunit;

namespace Tests
{
    public class FrameTest
    {
        [Fact]
        public void TestStartDelimiter()
        {
            Frame frame = new Frame();
            Assert.Equal(0xAA, frame.StartOfFrame());
        }

        [Fact]
        public void TestEndDelimiter()
        {
            Frame frame = new Frame();
            Assert.Equal(0x55, frame.EndOfFrame());
        }
    }
}
