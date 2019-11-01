using System;
using System.Collections.Generic;
using System.Text;

namespace LEDSeriesResistor
{
    public class ResistorCalculator
    {
        double supplyVoltage = 0;
        double ledVoltage = 0;
        double current = 0;

        public double CalculateSeriesResistor()
        {
            double resistance = 0;

            // TODO Determine the resistance value for the series resistor of the LED
            // Warning, set the value to -1 if the ledVoltage is bigger than the supplyVoltage
            // or if the current is 0 or negative.
            
            return resistance;
        }

        public double SupplyVoltage { get { return supplyVoltage; } set { supplyVoltage = value; } }
        public double LedVoltage { get { return ledVoltage; } set { ledVoltage = value; } }
        public double Current { get { return current; } set { current = value; } }
    }
}
