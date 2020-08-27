using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace chapter02
{
    class Class0215
    {
        static void Main0215() 
        {
            string firstname, lastname;

            WriteLine("Hey you");

            WriteLine("Please enter your firstname:");
            firstname = ReadLine();

            WriteLine("Please enter your lasttname:");
            lastname = ReadLine();

            WriteLine($"Your name is {firstname} {lastname}.");
        }

    }
}
