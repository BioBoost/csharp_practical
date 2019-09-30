using CalculateVAT;
using System;
using System.Reflection;
using Xunit;

namespace Tests
{
    public class UnitTestInvoice
    {
        private Invoice uut = new Invoice();

        private TReturn GetPrivateField<TReturn>(string fieldname)
        {
            Type type = uut.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            FieldInfo field = type.GetField(fieldname, bindingAttr);
            return (TReturn)field.GetValue(uut);
        }

        [Fact]
        public void TestGetVAT()
        {
            double expected = GetPrivateField<double>("netPrice") * GetPrivateField<double>("vatPercentage") / 100;
            Assert.Equal(expected, uut.GetVAT(), 2);
        }
    }
}
