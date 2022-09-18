using System;
using TeachTheTeacher;
using Xunit;

namespace Tests
{
    public class UnitTestTeacher
    {
        private Teacher teacher = new Teacher();

        public UnitTestTeacher()
        {
            teacher.SetFirstname("Nico");
            teacher.SetLastname("De Witte");
        }

        [Fact]
        public void TestFullname()
        {
            Assert.Equal("Nico De Witte", teacher.Fullname());
        }

        [Fact]
        public void TestEmail()
        {
            Assert.Equal("nico.dewitte@vives.be", teacher.Email());
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("Nico De Witte <nico.dewitte@vives.be>", teacher.ToString());
        }
    }
}
