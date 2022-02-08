using NumberManipulator;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestManipulator
    {
        [Fact]
        public void TestReverse()
        {
            Assert.Equal(54321, Manipulator.Reverse(12345));
            Assert.Equal(1337, Manipulator.Reverse(7331));
            Assert.Equal(0, Manipulator.Reverse(0));
            Assert.Equal(1, Manipulator.Reverse(1));
            Assert.Equal(8, Manipulator.Reverse(8000));
            Assert.Equal(111111, Manipulator.Reverse(111111));
        }

        [Fact]
        public void TestComplement()
        {
            Assert.Equal(87654, Manipulator.Complement(12345));
            Assert.Equal(2668, Manipulator.Complement(7331));
            Assert.Equal(8, Manipulator.Complement(1));
            Assert.Equal(1999, Manipulator.Complement(8000));
            Assert.Equal(8000, Manipulator.Complement(1999));
            Assert.Equal(888888, Manipulator.Complement(111111));
        }

        [Fact]
        public void TestDigitSum()
        {
            Assert.Equal(21, Manipulator.DigitSum(353235));
            Assert.Equal(19, Manipulator.DigitSum(34534));
            Assert.Equal(8, Manipulator.DigitSum(8));
            Assert.Equal(7, Manipulator.DigitSum(133));
            Assert.Equal(0, Manipulator.DigitSum(0));
            Assert.Equal(1, Manipulator.DigitSum(1));
            Assert.Equal(12, Manipulator.DigitSum(453));
            Assert.Equal(42, Manipulator.DigitSum(89988));
        }
    }
}
