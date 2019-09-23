using System;
using System.Collections.Generic;
using System.Text;

namespace MarcoPolo
{
    public class PersonalInformation
    {
        public string FullName()
        {
            string firstname = "Marco";
            string lastname = "Polo";

            // TODO: Concatenate firstname and lastname and assign to fullname
            string fullname = "";

            Console.WriteLine("Hello, I am " + fullname);

            // Please dont change the code below (automatic unit tests)
            return fullname;
        }

        public int Age()
        {
            // TODO: Initialize age to 19
            int age = 0;

            Console.WriteLine("I am " + age + " years of age.");

            // Please dont change the code below (automatic unit tests)
            return age;
        }

        public string EyeColor()
        {
            // TODO: Set the color of my eyes to blue
            string colorOfMyEyes = "grey";

            Console.WriteLine("I have fancy " + colorOfMyEyes + " colored eyes.");

            // Please dont change the code below (automatic unit tests)
            return colorOfMyEyes;
        }
    }
}
