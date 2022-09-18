using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaTime
{
    public class PizzaDivider
    {
        int numberOfPeople = 6;
        int slicesOfPizza = 13;

        public int HowManySlicesPerPerson()
        {
            // TODO Determine how many slices of pizza a person can have (same for everyone)
            int slicesPerPerson = 0;

            // Please dont change the code below (automatic unit tests)
            return slicesPerPerson;
        }

        public int HowManySlicesLeft()
        {
            // TODO Determine number of slices left if everyone gets his/her fair chance
            int numberOfSlicesLeft = 0;

            // Please dont change the code below (automatic unit tests)
            return numberOfSlicesLeft;
        }

        public void PrintToTerminal()
        {
            Console.WriteLine("There are " + numberOfPeople + " people eating pizza.");
            Console.WriteLine("There are " + slicesOfPizza + " slices of pizza.");
            Console.WriteLine("We give everyone " + HowManySlicesPerPerson() + " slices of pizza.");
            Console.WriteLine("In the end we will have " + HowManySlicesLeft() + " slices left in the end.");
        }
    }
}
