using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class Summator
    {
        public int Sum(int[] values)
        {
            int sum = 0;

            // TODO Determine the absolute sum of all the numbers in the values array
            // TODO If the array does not contain any values (Length is 0), the result should be 0

            // With Math.Abs
            foreach (var value in values)
            {
                sum += Math.Abs(value);
            }

            // Without Math.Abs
            //foreach (var value in values)
            //{
            //    if (value < 0)
            //    {
            //        sum -= value;
            //    }
            //    else
            //    {
            //        sum += value;
            //    }
            //}

            return sum;
        }
    }
}
