using System;

namespace chapter04
{
    class Program
    {
        static void Main()
        {
            int difference = 4 - 2;
            int numberator, denominator, quotient, remainder;

            System.Console.Write("Enter the numberator:");
            numberator = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the denominator:");
            denominator = int.Parse(System.Console.ReadLine());

            quotient = numberator / denominator;
            remainder = numberator % denominator;

            System.Console.WriteLine($"{numberator} / {denominator} = {quotient} with {remainder}");

        }
    }
}
