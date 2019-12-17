using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class EmailValidator
    {
        public bool IsValidEmail(string email)
        {
            bool isValid = false;

            // TODO Check if email contains an @
            // TODO Check if email contains a . after the @ with at least 1 letter in between
            // TODO Check if at least 1 letter proceeds the @
            // TODO Check if at least 1 letter is present after the last .

            int at = email.IndexOf("@");
            int dot = email.LastIndexOf(".");

            isValid = (at > 1 && dot > (at + 1) && dot < email.Length - 1);

            return isValid;
        }
    }
}
