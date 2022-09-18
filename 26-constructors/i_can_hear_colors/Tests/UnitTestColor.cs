using ICanHearColors;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestColor
    {
        private Color color = new Color();

        [Fact]
        public void TestColorPropertyRed()
        {
            color.Red = 123;
            Assert.Equal(123, color.Red);

            color.Red = -23;
            Assert.Equal(0, color.Red);

            color.Red = 643;
            Assert.Equal(255, color.Red);
        }

        [Fact]
        public void TestColorPropertyGreen()
        {
            color.Green = 234;
            Assert.Equal(234, color.Green);

            color.Green = -44;
            Assert.Equal(0, color.Green);

            color.Green = 8754;
            Assert.Equal(255, color.Green);
        }

        [Fact]
        public void TestColorPropertyBlue()
        {
            color.Blue = 21;
            Assert.Equal(21, color.Blue);

            color.Blue = -32;
            Assert.Equal(0, color.Blue);

            color.Blue = 763;
            Assert.Equal(255, color.Blue);
        }

        [Fact]
        public void TestDefaultConstructor()
        {
            color = new Color();
            Assert.Equal(0, color.Red);
            Assert.Equal(0, color.Green);
            Assert.Equal(0, color.Blue);
        }

        [Fact]
        public void TestInitializationConstructor()
        {
            color = new Color(123, 34, 30);
            Assert.Equal(123, color.Red);
            Assert.Equal(34, color.Green);
            Assert.Equal(30, color.Blue);

            color = new Color(-23, -45, -30);
            Assert.Equal(0, color.Red);
            Assert.Equal(0, color.Green);
            Assert.Equal(0, color.Blue);

            color = new Color(423, 465, 380);
            Assert.Equal(255, color.Red);
            Assert.Equal(255, color.Green);
            Assert.Equal(255, color.Blue);
        }

        [Fact]
        public void TestToString()
        {
            color = new Color(44, 99, 144);
            Assert.Equal("Red: 44 | Green: 99 | Blue: 144", color.ToString());

            color = new Color(-283, -454, -350);
            Assert.Equal("Red: 0 | Green: 0 | Blue: 0", color.ToString());

            color = new Color(473, 5665, 3850);
            Assert.Equal("Red: 255 | Green: 255 | Blue: 255", color.ToString());
        }
    }
}
