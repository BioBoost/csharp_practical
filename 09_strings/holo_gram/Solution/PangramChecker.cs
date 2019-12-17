using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class PangramChecker
    {
        public bool IsPangram(string text)
        {
            bool isAPangram = true;

            // TODO Check if text is a pangram and thereby contains all the letters of the alphabet
            // TODO Convert text to lowercase first

            char ch = 'a';
            while (isAPangram && ch <= 'z')
            {
                if (text.IndexOf(ch) < 0)
                {
                    isAPangram = false;
                }
                ch++;
            }

            return isAPangram;
        }
    }
}
