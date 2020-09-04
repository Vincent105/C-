using System;
using System.Collections.Generic;
using System.Text;

namespace chapter04
{
    class Class1
    {
        static void Main0443()
        {
            decimal current;
            decimal previous;
            decimal temp;
            decimal input;

            System.Console.Write("Enter the integer.");
            input = decimal.Parse(System.Console.ReadLine());

            current = previous = 1;

            while (current <= input)
            {
                temp = current;
                current = previous + current;
                previous = temp;
            }

            System.Console.WriteLine($"{current}");
        }
    }
}
