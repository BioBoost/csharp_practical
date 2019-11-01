using LEDSeriesResistor;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestsResistorCalculator
    {
        private ResistorCalculator calculator = new ResistorCalculator();

        [Fact]
        public void TestSupplyVoltageOk()
        {
            calculator.SupplyVoltage = 5;
            calculator.LedVoltage = 1.2;
            calculator.Current = 0.010;

            Assert.Equal(380, calculator.CalculateSeriesResistor(), 3);
        }

        [Fact]
        public void TestSupplyVoltageTooSmall()
        {
            calculator.SupplyVoltage = 1;
            calculator.LedVoltage = 1.2;
            calculator.Current = 0.010;

            Assert.Equal(-1, calculator.CalculateSeriesResistor(), 3);
        }

        [Fact]
        public void TestCurrentZero()
        {
            calculator.SupplyVoltage = 5;
            calculator.LedVoltage = 1.2;
            calculator.Current = 0;

            Assert.Equal(-1, calculator.CalculateSeriesResistor(), 3);
        }
    }
}
