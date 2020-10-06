using System;

namespace TossADieToYourWitcher
{
    class Program
    {
        static int ThrowDie()
        {
            Random generator = new Random();
            return generator.Next(1, 7);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Throwing a die ...");

            // dieValue will need to be assigned the result of
            // of the ThrowDie() method
            int dieValue = 0;

            // TODO Call the ThrowDie method and store the result
            // that is returned by the method in the variable dieValue



            // Output result to terminal
            Console.WriteLine("Cool, we threw " + dieValue);
        }
    }
}
