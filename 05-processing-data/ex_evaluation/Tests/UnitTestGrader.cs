using Evaluation;
using System;
using System.Reflection;
using Xunit;

namespace Tests
{
    public class UnitTestGrader
    {
        private Grader uut = new Grader();

        private TReturn GetPrivateField<TReturn>(string fieldname)
        {
            Type type = uut.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            FieldInfo field = type.GetField(fieldname, bindingAttr);
            return (TReturn)field.GetValue(uut);
        }

        [Fact]
        public void TestAverage()
        {
            Assert.Equal((GetPrivateField<double>("examScore") + GetPrivateField<double>("labScore"))/2,
                uut.Average(), 2);
        }

        [Fact]
        public void TestTotal()
        {
            double expected = (2 * GetPrivateField<double>("examScore") +
                3 * GetPrivateField<double>("labScore")) / 5;
            Assert.Equal(expected,
                uut.Total(), 2);
        }
    }
}
