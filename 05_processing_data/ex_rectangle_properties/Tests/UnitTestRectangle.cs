using RectangleProperties;
using System;
using System.Reflection;
using Xunit;

namespace Tests
{
    public class UnitTestRectangle
    {
        private Rectangle uut = new Rectangle();

        private TReturn GetPrivateField<TReturn>(string fieldname)
        {
            Type type = uut.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            FieldInfo field = type.GetField(fieldname, bindingAttr);
            return (TReturn)field.GetValue(uut);
        }

        [Fact]
        public void TestArea()
        {
            Assert.Equal(GetPrivateField<double>("width") * GetPrivateField<double>("height"),
                uut.CalculateArea());
        }

        [Fact]
        public void TestCircumference()
        {
            Assert.Equal(2*(GetPrivateField<double>("width") + GetPrivateField<double>("height")),
                uut.CalculateCircumference());
        }
    }
}
