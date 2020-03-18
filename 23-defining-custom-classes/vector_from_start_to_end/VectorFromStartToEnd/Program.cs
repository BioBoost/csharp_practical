using System;

namespace VectorFromStartToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Vectors - From Start to End");
            Console.WriteLine("This app allows you to insert mathematical vectors");
            Console.WriteLine("and calculate the resulting total vector.\n");

            VectorPath path = new VectorPath();
            bool keepAddingVectors = true;
            do
            {
                Console.Write("Please enter the x and y coordinates (separated with space - both zero stops): ");
                string[] coordinates = Console.ReadLine().Split(" ");

                if (coordinates[0] != "0" && coordinates[0] != "0")
                {
                    double x = Convert.ToDouble(coordinates[0]);
                    double y = Convert.ToDouble(coordinates[1]);
                    path.Add(new Vector(x, y));
                }
                else
                {
                    keepAddingVectors = false;
                }
                
            } while (keepAddingVectors);

            Console.WriteLine("\n-------------------------------------------------------");
            Console.WriteLine("Summing all vector:");
            Console.WriteLine(path);
            Console.WriteLine("\nThe resulting vector is: " + path.ResultingVector());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("\nThank you for using our app");
        }
    }
}
