using ProgrammingBugs;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestMessageOfTheDay
    {
        [Fact]
        public void TestShowMessage()
        {
            MessageOfTheDay message = new MessageOfTheDay();
            Assert.Equal("If debugging is the process of removing software bugs, " +
                "then programming must be the process of putting them in.\n" +
                "\tBy \"Edsger Dijkstra\"", message.ShowMessage());
        }
    }
}
