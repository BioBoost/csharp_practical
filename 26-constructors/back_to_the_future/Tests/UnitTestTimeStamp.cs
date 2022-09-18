using BackToTheFuture;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestTimeStamp
    {
        private TimeStamp timestamp = new TimeStamp();

        [Fact]
        public void TestDefaultConstructor()
        {
            timestamp = new TimeStamp();
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(0, timestamp.Hours);
        }

        [Fact]
        public void TestFullConstructor()
        {
            timestamp = new TimeStamp(12, 13, 21);
            Assert.Equal(12, timestamp.Hours);
            Assert.Equal(13, timestamp.Minutes);
            Assert.Equal(21, timestamp.Seconds);

            timestamp = new TimeStamp(8, 65, 33);
            Assert.Equal(9, timestamp.Hours);
            Assert.Equal(5, timestamp.Minutes);
            Assert.Equal(33, timestamp.Seconds);

            timestamp = new TimeStamp(24, 86, 105);
            Assert.Equal(1, timestamp.Hours);
            Assert.Equal(27, timestamp.Minutes);
            Assert.Equal(45, timestamp.Seconds);

            timestamp = new TimeStamp(24, 0, 0);
            Assert.Equal(0, timestamp.Hours);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(0, timestamp.Seconds);

            timestamp = new TimeStamp(-13, -22, -88);
            Assert.Equal(0, timestamp.Hours);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(0, timestamp.Seconds);
        }

        [Fact]
        public void TestSeconds()
        {
            timestamp = new TimeStamp();

            timestamp.Seconds = 5;
            Assert.Equal(5, timestamp.Seconds);

            timestamp.Seconds = 103;
            Assert.Equal(43, timestamp.Seconds);

            timestamp.Seconds = 60;
            Assert.Equal(0, timestamp.Seconds);

            timestamp.Seconds = -32;
            Assert.Equal(0, timestamp.Seconds);
        }

        [Fact]
        public void TestMinutes()
        {
            timestamp = new TimeStamp();

            timestamp.Minutes = 3;
            Assert.Equal(3, timestamp.Minutes);

            timestamp.Minutes = 99;
            Assert.Equal(39, timestamp.Minutes);

            timestamp.Minutes = 60;
            Assert.Equal(0, timestamp.Minutes);

            timestamp.Minutes = -40;
            Assert.Equal(0, timestamp.Minutes);
        }

        [Fact]
        public void TestHours()
        {
            timestamp = new TimeStamp();

            timestamp.Hours = 13;
            Assert.Equal(13, timestamp.Hours);

            timestamp.Hours = 99;
            Assert.Equal(3, timestamp.Hours);

            timestamp.Hours = 48;
            Assert.Equal(0, timestamp.Hours);

            timestamp.Hours = -40;
            Assert.Equal(0, timestamp.Hours);
        }

        [Fact]
        public void TestAddSeconds()
        {
            timestamp = new TimeStamp();

            timestamp.AddSeconds(10);
            Assert.Equal(10, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(0, timestamp.Hours);

            timestamp.AddSeconds(100);
            Assert.Equal(50, timestamp.Seconds);
            Assert.Equal(1, timestamp.Minutes);
            Assert.Equal(0, timestamp.Hours);

            timestamp.AddSeconds(60 * 60 + 60 + 1);
            Assert.Equal(51, timestamp.Seconds);
            Assert.Equal(2, timestamp.Minutes);
            Assert.Equal(1, timestamp.Hours);

            timestamp.AddSeconds(60 * 60 * 22);
            Assert.Equal(51, timestamp.Seconds);
            Assert.Equal(2, timestamp.Minutes);
            Assert.Equal(23, timestamp.Hours);
        }

        [Fact]
        public void TestAddMinutes()
        {
            timestamp = new TimeStamp();

            timestamp.AddMinutes(1);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(1, timestamp.Minutes);
            Assert.Equal(0, timestamp.Hours);

            timestamp.AddMinutes(59);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(1, timestamp.Hours);

            timestamp.AddMinutes(60 * 22 + 15);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(15, timestamp.Minutes);
            Assert.Equal(23, timestamp.Hours);

            timestamp.AddMinutes(60);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(15, timestamp.Minutes);
            Assert.Equal(0, timestamp.Hours);
        }

        [Fact]
        public void TestAddHours()
        {
            timestamp = new TimeStamp();

            timestamp.AddHours(1);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(1, timestamp.Hours);

            timestamp.AddHours(22);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(23, timestamp.Hours);

            timestamp.AddHours(1);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(0, timestamp.Hours);

            timestamp.AddHours(27);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(3, timestamp.Hours);
        }

        [Fact]
        public void TestAddNegativeSeconds()
        {
            timestamp = new TimeStamp();

            timestamp.AddSeconds(-3);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(0, timestamp.Hours);
        }

        [Fact]
        public void TestAddNegativeMinutes()
        {
            timestamp = new TimeStamp();

            timestamp.AddMinutes(-12);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(0, timestamp.Hours);
        }

        [Fact]
        public void TestAddNegativeHours()
        {
            timestamp = new TimeStamp();

            timestamp.AddHours(-21);
            Assert.Equal(0, timestamp.Seconds);
            Assert.Equal(0, timestamp.Minutes);
            Assert.Equal(0, timestamp.Hours);
        }

    }
}
