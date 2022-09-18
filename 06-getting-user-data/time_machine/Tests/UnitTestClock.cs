using System;
using TimeMachine;
using Xunit;

namespace Tests
{
    public class UnitTestClock
    {
        Clock clock = new Clock();

        [Fact]
        public void TestAddHours()
        {
            int delta = 25;
            int expected = (clock.Hours + delta) % 24;
            clock.AddHours(delta);
            Assert.Equal(expected, clock.Hours);
        }

        [Fact]
        public void TestAddMinutes()
        {
            int delta = 125;
            int expectedHours = (clock.Hours + ((delta + clock.Minutes) / 60)) % 24;
            int expectedMinutes = (clock.Minutes + delta) % 60;

            clock.AddMinutes(delta);
            Assert.Equal(expectedHours, clock.Hours);
            Assert.Equal(expectedMinutes, clock.Minutes);
        }
    }
}
