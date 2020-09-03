using System;
using System.Collections.Generic;
using System.Text;

namespace chapter04
{
    class Class0420
    {
        static void Main0420()
        {
            string input;

            System.Console.Write(
                "1-play against the computer\n" + 
                "2-play against the player.\n" +
                "Choose:");
            input = System.Console.ReadLine();
            if (input == "1")
                System.Console.WriteLine("Player against computer");
            else
                System.Console.WriteLine("Player against player");
        }
    }
}
