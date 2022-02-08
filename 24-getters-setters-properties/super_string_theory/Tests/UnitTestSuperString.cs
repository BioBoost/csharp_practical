using SuperStringTheory;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestSuperString
    {
        private SuperString myString = new SuperString();

        [Fact]
        public void TestIfTextPropertyExists()
        {
            Assert.NotNull(myString.GetType().GetProperty("Text"));
        }

        [Fact]
        public void TestIfGettersSettersAreNotPresent()
        {
            Assert.Null(myString.GetType().GetMethod("GetText"));
            Assert.Null(myString.GetType().GetMethod("SetText"));
        }

        [Fact]
        public void TestNullText()
        {
            myString.Text = null;
            Assert.Equal("", myString.Text);
        }

        [Fact]
        public void TestAppendText()
        {
            myString.Text = "Hello";
            myString.Append(" World");
            Assert.Equal("Hello World", myString.Text);

            myString.Text = "  I am";
            myString.Append("      Mister Roboto   ");
            Assert.Equal("  I am      Mister Roboto   ", myString.Text);

            myString.Text = "C# is cool!";
            myString.Append("");
            Assert.Equal("C# is cool!", myString.Text);
        }

        [Fact]
        public void TestPrependText()
        {
            myString.Text = "Hello";
            myString.Prepend("Lets say ");
            Assert.Equal("Lets say Hello", myString.Text);

            myString.Text = "   Where is my car ?    ";
            myString.Prepend("      Dude !   ");
            Assert.Equal("      Dude !      Where is my car ?    ", myString.Text);

            myString.Text = "C# is cool!";
            myString.Prepend("");
            Assert.Equal("C# is cool!", myString.Text);
        }

        [Fact]
        public void TestIsValidNumber()
        {
            myString.Text = "1234";
            Assert.True(myString.IsValidNumber());

            myString.Text = "74-56";
            Assert.False(myString.IsValidNumber());

            myString.Text = "0";
            Assert.True(myString.IsValidNumber());

            myString.Text = "ewrqwwhquqrew";
            Assert.False(myString.IsValidNumber());

            myString.Text = "#0950534958";
            Assert.False(myString.IsValidNumber());

            myString.Text = "";
            Assert.False(myString.IsValidNumber());

            myString.Text = "     ";
            Assert.False(myString.IsValidNumber());
        }

        [Fact]
        public void TestTrimStart()
        {
            myString.Text = "Hello World from C# and Unit Tests!";
            myString.TrimStart();
            Assert.Equal("Hello World from C# and Unit Tests!", myString.Text);

            myString.Text = "                       ";
            myString.TrimStart();
            Assert.Equal("", myString.Text);

            myString.Text = "   Only at the beginning!";
            myString.TrimStart();
            Assert.Equal("Only at the beginning!", myString.Text);

            myString.Text = "Only at the end!       ";
            myString.TrimStart();
            Assert.Equal("Only at the end!       ", myString.Text);

            myString.Text = "";
            myString.TrimStart();
            Assert.Equal("", myString.Text);
        }

        [Fact]
        public void TestTrimEnd()
        {
            myString.Text = "There is nothing to trim here!";
            myString.TrimEnd();
            Assert.Equal("There is nothing to trim here!", myString.Text);

            myString.Text = "                       ";
            myString.TrimEnd();
            Assert.Equal("", myString.Text);

            myString.Text = "   Only at the beginning!";
            myString.TrimEnd();
            Assert.Equal("   Only at the beginning!", myString.Text);

            myString.Text = "Only at the end!       ";
            myString.TrimEnd();
            Assert.Equal("Only at the end!", myString.Text);

            myString.Text = "";
            myString.TrimEnd();
            Assert.Equal("", myString.Text);
        }

        [Fact]
        public void TestTrim()
        {
            myString.Text = "No trimming please ...";
            myString.Trim();
            Assert.Equal("No trimming please ...", myString.Text);

            myString.Text = "                       ";
            myString.Trim();
            Assert.Equal("", myString.Text);

            myString.Text = "   Only at the beginning!";
            myString.Trim();
            Assert.Equal("Only at the beginning!", myString.Text);

            myString.Text = "Only at the end!       ";
            myString.Trim();
            Assert.Equal("Only at the end!", myString.Text);

            myString.Text = "";
            myString.Trim();
            Assert.Equal("", myString.Text);
        }
    }
}
