using System;

namespace NotMyMail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to email validator ...");

            EmailValidator validator = new EmailValidator();
            string email = "";
            do
            {
                Console.Write("Please enter email to check. Leave empty to stop.: ");
                email = Console.ReadLine();
                if (email != "")
                {
                    if (validator.IsValidEmail(email))
                    {
                        Console.WriteLine("This is a valid email address");
                    }
                    else
                    {
                        Console.WriteLine("This email address is NOT valid");
                    }
                }
            } while (email != "");

            Console.WriteLine("Thanks for using our validation app.");
        }
    }
}
