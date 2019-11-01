using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class AppleCakeGenerator
    {
        public string AppleCake(int value)
        {
            string text = "";

            // TODO Assign the correct string according to value
            // If value is dividable by 3, text should be "apple"
            // If value is dividable by 5, text should be "cake"
            // If value is dividable by 3 and 5, text should be "applecake"
            // In all other cases the string should be left empty
            if (value % 3 == 0 && value % 5 == 0)
            {
                text = "applecake";
            }
            else if (value % 3 == 0)
            {
                text = "apple";
            }
            else if (value % 5 == 0)
            {
                text = "cake";
            }


            return text;
        }

        public string Generate(int start, int end)
        {
            string output = "";

            // TODO Create a loop that iterates over all the numbers from start to end
            // Add the output of AppleCake(i) to the output string in each iteration
            // in the following format (also see README.md for expected output)
            // 3: apple
            //
            // If its an empty result, then don't add it to the output

            // Place the following in the body of your loop and replace the 3
            // with your iterator (i for example).
            //string text = AppleCake(3);

            for (int i = start; i <= end; i++)
            {
                string text = AppleCake(i);
                if (text != "")
                {
                    output += $"{i}: {text}\n";
                }
            }

            return output;
        }
    }
}
