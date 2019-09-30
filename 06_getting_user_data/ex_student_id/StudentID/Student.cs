using System;
using System.Collections.Generic;
using System.Text;

namespace StudentID
{
    public class Student
    {
        // Feel free to change these values but keep them
        // with a capital letter to make sure your Email() method is correct
        string firstname = "Marco";
        string lastname = "Polo";

        public string Email()
        {
            // TODO: Generate email for the student in the following format:
            // firstname.lastname@student.vives.be
            // Make sure that all letters are lowercase letters
            string email = "";

            // Please dont change the code below (automatic unit tests)
            return email;
        }

        public string ID()
        {
            // TODO: Generate an ID for the student (random number of 6 digits)
            // Put it into the following format: rxxxxxx
            // r is a prefix and each x is a digit
            string id = "";

            // Please dont change the code below (automatic unit tests)
            return id;
        }

        public void PrintToTerminal()
        {
            Console.WriteLine("Student information:");
            Console.WriteLine($"Firstname: {firstname}");
            Console.WriteLine($"Lastname: {lastname}");
            Console.WriteLine($"Email: {Email()}");
            Console.WriteLine($"ID: {ID()}");
        }
    }
}
