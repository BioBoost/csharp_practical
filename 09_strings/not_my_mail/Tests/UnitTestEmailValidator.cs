using NotMyMail;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestEmailValidator
    {
        private EmailValidator validator = new EmailValidator();

        [Fact]
        public void TestBasicEmails()
        {
            Assert.True(validator.IsValidEmail("nico@devbit.be"));
            Assert.False(validator.IsValidEmail("nico.devbit.be"));
            Assert.False(validator.IsValidEmail("@devbit.be"));
            Assert.False(validator.IsValidEmail("nico@devbit"));
        }

        [Fact]
        public void TestAdvancedEmails()
        {
            Assert.True(validator.IsValidEmail("nico.dewitte@devbit.be"));
            Assert.False(validator.IsValidEmail("nico@"));
            Assert.False(validator.IsValidEmail("nico@com"));
            Assert.False(validator.IsValidEmail("nico@."));
            Assert.False(validator.IsValidEmail("nico@.com"));
            Assert.False(validator.IsValidEmail("nico@devbit."));
            Assert.False(validator.IsValidEmail("nico"));
            Assert.False(validator.IsValidEmail("@"));
            Assert.False(validator.IsValidEmail(""));
        }
    }
}



