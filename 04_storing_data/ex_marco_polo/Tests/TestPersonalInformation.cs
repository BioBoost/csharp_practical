using MarcoPolo;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestPersonalInformation
    {
        [Fact]
        public void TestName()
        {
            PersonalInformation info = new PersonalInformation();
            Assert.Equal("Marco Polo", info.FullName());
        }

        [Fact]
        public void TestAge()
        {
            PersonalInformation info = new PersonalInformation();
            Assert.Equal(19, info.Age());
        }

        [Fact]
        public void TestEyeColor()
        {
            PersonalInformation info = new PersonalInformation();
            Assert.Equal("blue", info.EyeColor());
        }
    }
}
