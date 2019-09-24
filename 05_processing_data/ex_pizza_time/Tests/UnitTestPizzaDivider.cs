using PizzaTime;
using System;
using System.Reflection;
using Xunit;

namespace Tests
{
    public class UnitTestPizzaDivider
    {
        private PizzaDivider uut = new PizzaDivider();

        private TReturn GetPrivateField<TReturn>(string fieldname)
        {
            Type type = uut.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            FieldInfo field = type.GetField(fieldname, bindingAttr);
            return (TReturn)field.GetValue(uut);
        }

        [Fact]
        public void TestSlicesPerPerson()
        {
            int expected = GetPrivateField<int>("slicesOfPizza") / GetPrivateField<int>("numberOfPeople");
            Assert.Equal(expected, uut.HowManySlicesPerPerson());
        }

        [Fact]
        public void TestSlicesLeft()
        {
            int expected = GetPrivateField<int>("slicesOfPizza") % GetPrivateField<int>("numberOfPeople");
            Assert.Equal(expected, uut.HowManySlicesLeft());
        }
    }
}
