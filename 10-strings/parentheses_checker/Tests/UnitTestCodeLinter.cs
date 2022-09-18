using ParenthesesChecker;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestCodeLinter
    {
        private CodeLinter linter = new CodeLinter();

        [Fact]
        public void TestValidSimpleConsoleWriteLine()
        {
            string code = @"Console.WriteLine(""Hello World"");";
            Assert.True(linter.HasMatchingParentheses(code));
        }

        [Fact]
        public void TestInvalidSimpleConsoleWriteLine()
        {
            string code = @"Console.WriteLine(""Hello World"";";
            Assert.False(linter.HasMatchingParentheses(code));
        }

        [Fact]
        public void TestInvalidSimpleConsoleWriteLineStartingWithClosing()
        {
            string code = @"Console.WriteLine""Hello World"");";
            Assert.False(linter.HasMatchingParentheses(code));
        }

        [Fact]
        public void TestComplexValidBooleanExpression()
        {
            string code = @"boolean valid = ((A > B) || (C < D));";
            Assert.True(linter.HasMatchingParentheses(code));
        }

        [Fact]
        public void TestComplexInValidBooleanExpression()
        {
            string code = @"boolean valid = ((A > B) || (C < D);";
            Assert.False(linter.HasMatchingParentheses(code));
        }

        [Fact]
        public void TestInvalidConsoleWriteLineStartingWithOpening()
        {
            string code = @"Console.WriteLine)((""Hello World"");";
            Assert.False(linter.HasMatchingParentheses(code));
        }

        [Fact]
        public void TestSomeInsaneInvalidParenthesesList()
        {
            string code = @"((()())())()))";
            Assert.False(linter.HasMatchingParentheses(code));
        }

        [Fact]
        public void TestSomeInsaneValidParenthesesList()
        {
            string code = @"((()())())(())";
            Assert.True(linter.HasMatchingParentheses(code));
        }
    }
}
