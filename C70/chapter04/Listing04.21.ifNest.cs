using System;
using System.Collections.Generic;
using System.Text;

namespace chapter04
{
    class Class0443
    {
        static void Main0421()
        {
            int input;

            System.Console.WriteLine(
                "What is the maximum number" +
                "Enter 0 to exit"
                );
            input = int.Parse(System.Console.ReadLine());

            if (input <= 0)
                System.Console.WriteLine("Exiting...");
            else if (input < 9)
                System.Console.WriteLine(
                    $"No,it has more than {input}");
            else if (input > 9)
                System.Console.WriteLine(
                    $"No,it has less than {input}");
            else
                System.Console.WriteLine(
                    $"Correct,it has {input}");
        }
    }
}
