using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryNibble
{
    public class NumberSystemConverter
    {
        public string DecimalToBinary(int decimalValue)
        {
            // TODO Convert the decimal value to
            // binary string representation
            string binary = "";

            int i = 0;
            while (decimalValue > 0)
            {
                if (i == 4) binary = " " + binary;

                if (decimalValue % 2 == 1)
                {
                    binary = "1" + binary;
                }
                else
                {
                    binary = "0" + binary;
                }

                decimalValue /= 2;
                i++;
            }

            for (; i < 8; i++)
            {
                if (i == 4) binary = " " + binary;
                binary = "0" + binary;
            }

            return binary;
        }
    }
}
