using System;

namespace chapter05
{
    class IntroducingMethod
    {
        public static void Main0502(string[] args)
        {
            string firstname,lastname,fullname;

            System.Console.WriteLine("Hey You!");
            firstname = GetUserInput("Enter your first name:");
            lastname = GetUserInput("Enter your last name:");

            fullname = GetFullName(firstname, lastname);
            DisplayGreeting(fullname);
        }

        static string GetUserInput(string prompt)
        {
            System.Console.Write(prompt);
            return System.Console.ReadLine();
        }

        static string GetFullName(string firstname, string lastname)
        {
            return $"{firstname} {lastname}";
        }

        static void DisplayGreeting(string fullname) 
        {
            System.Console.WriteLine($"Hi, Your fullname is {fullname}");
            return;
        }
    }
}
