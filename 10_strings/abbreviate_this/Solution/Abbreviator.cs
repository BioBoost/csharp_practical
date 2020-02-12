using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class Abbreviator
    {

        public string Abbreviate(string text)
        {
            string letters = "";

            // TODO Convert text to an abbreviation
            // TODO Make sure that the end result contains upper-case letters only
            // TODO If text is empty, than so should letters be

            if (text.Length > 0)
            {
                letters += text[0];
                for (int i = 1; i < text.Length; i++)
                {
                    if (text[i - 1] == ' ')
                    {
                        letters += text[i];
                    }
                }
            }

            // Or with split
            //if (text.Length > 0)
            //{
            //    string[] words = text.Split(' ');
            //    foreach (string word in words)
            //    {
            //        letters += word[0];
            //    }
            //}

            return letters.ToUpper();
        }
    }
}
