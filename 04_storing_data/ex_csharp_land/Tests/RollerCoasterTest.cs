using CSharpLand;
using System;
using Xunit;

namespace Tests
{
    public class RollerCoasterTest
    {
        [Fact]
        public void TestMinimumHeight()
        {
            RollerCoaster coaster = new RollerCoaster();
            Assert.Equal(1.30, coaster.ShowMinimumHeight(), 2);
        }
    }
}
