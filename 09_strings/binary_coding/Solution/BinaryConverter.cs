using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class BinaryConverter
    {
        public int ToDecimal(string binary)
        {
            int decimalValue = 0;

            // TODO Convert the binary value in the variabel binary
            // to a decimal value
            //
            // Do note that it contain spaces, ignore these.
            //
            // It cal also start with a character 'b' which
            // should also be ignored.
            // Ex.: b1001 0101

            int power = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalValue += power;
                    power *= 2;
                }
                else if (binary[i] == '0')
                {
                    power *= 2;
                }
            }

            return decimalValue;
        }
    }
}
