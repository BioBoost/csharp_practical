using DriftingYears;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestLeapYearChecker
    {
        LeapYearChecker uut = new LeapYearChecker();

        [Fact]
        public void TestIsLeapYear()
        {
            Assert.True(uut.IsLeapYear(1600));
            Assert.True(uut.IsLeapYear(2000));
            Assert.True(uut.IsLeapYear(2004));
            Assert.True(uut.IsLeapYear(1904));

            Assert.False(uut.IsLeapYear(1700));
            Assert.False(uut.IsLeapYear(1800));
            Assert.False(uut.IsLeapYear(1900));
        }
    }
}
