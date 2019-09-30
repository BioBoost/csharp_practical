using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateVAT
{
    public class Invoice
    {
        double netPrice = 250.0;
        double vatPercentage = 21;

        public double GetVAT()
        {
            // TODO: Calculate the vat percentage of the net value
            double vat = 0;

            // Please dont change the code below (automatic unit tests)
            return vat;
        }

        public double GetTotal()
        {
            return netPrice + GetVAT();
        }

        public void PrintToTerminal()
        {
            Console.WriteLine("For a net value of " + netPrice + "euro");
            Console.WriteLine("you need to pay " + vatPercentage + "% VAT.");
            Console.WriteLine("So the total price you pay is");
            Console.WriteLine(netPrice + "euro " + "+ " + GetVAT() + "euro = " + GetTotal() + "euro");
        }
    }
}
