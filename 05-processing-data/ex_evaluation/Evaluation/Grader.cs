using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation
{
    public class Grader
    {
        double examScore = 13.5;
        double labScore = 16.2;
        string studentName = "Lenny Dermond";

        public double Average()
        {
            // TODO: Determine average of exam score and lab score
            double average = 0;

            // Please dont change the code below (automatic unit tests)
            return average;
        }

        public double Total()
        {
            // TODO: Determine total score if exam counts for 40% and lab for 60%
            double total = 0;

            // Please dont change the code below (automatic unit tests)
            return total;
        }

        public void PrintToTerminal()
        {
            Console.WriteLine(studentName + ":");
            Console.WriteLine("\tExam Score: " + examScore + "/20");
            Console.WriteLine("\tLAB Score: " + labScore + "/20");
            Console.WriteLine("\tAverage Score: " + Average());
            Console.WriteLine("\tTotal Score: " + Total());
        }
    }
}
