using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStringTheory
{
    public class SuperString
    {
        // Text getter method
        // TODO - Replace with property
        public string GetText()
        {
            return text;
        }

        // Text setter method
        // TODO - Replace with property
        public void SetText(string text)
        {
            this.text = text;
        }


        public void Append(string text)
        {
            // TODO - Append the local argument text behind the attribute text
        }


        // TODO - Add a Prepend() method

        public bool IsValidNumber()
        {
            // TODO - Check if text is a valid number.

            return false;
        }

        public void TrimStart()
        {
            // TODO - Remove any spaces at the beginning of text.
        }

        // TODO - Add a TrimEnd() method

        // TODO - Add a Trim() method

        // Attributes
        private string text = "";
    }
}
