using System;

namespace CalculateVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.PrintToTerminal();
        }
    }
}
