using System;
using System.Collections.Generic;
using System.Text;

namespace chapter05
{
    class Class0506
    {
        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return System.Console.ReadLine();
        }

        static (string firstname, string lastname) GetName()
        {
            string firstname, lastname;
            firstname = GetUserInput("Enter firstname:");
            lastname = GetUserInput("Enter lastname:");
            return (firstname,lastname);
        }

        static void Main0506()
        {
            (string first, string last) name = GetName();
            System.Console.WriteLine($"Hi,{name.first} {name.last}");
        }


    }
}
