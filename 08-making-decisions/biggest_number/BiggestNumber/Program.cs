using System;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Biggest biggest = new Biggest();

            Console.WriteLine($"The biggest number of (1, -3, 104) = {biggest.DetermineBiggest(1, -3, 104)}");
            Console.WriteLine($"The biggest number of (-5, 11, 3) = {biggest.DetermineBiggest(-5, 11, 3)}");
            Console.WriteLine($"The biggest number of (0, 109, 66) = {biggest.DetermineBiggest(0, 109, 66)}");
        }
    }
}
