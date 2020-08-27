using System;
using System.Diagnostics.SymbolStore;

namespace chapter02
{
    class Program
    {
        static void Main0214(string[] args)
        {
            string text, firstname, lastname, option;

            System.Console.Write("Please enter your firstname:");
            firstname = System.Console.ReadLine();

            System.Console.Write("Please enter your lastname:");
            lastname = System.Console.ReadLine();

            System.Console.Write("Please enter your option:");
            option = System.Console.ReadLine();

            text = string.Format("Your name is {0}{1}.", firstname, lastname);
            System.Console.Write("01:string format===>");
            System.Console.WriteLine(text);

            text = string.Concat(firstname, lastname);
            System.Console.Write("02:string Concat===>");
            System.Console.WriteLine(text);

            int result = string.Compare(option, "/help");
            System.Console.WriteLine(result);

            bool isPhd = lastname.EndsWith("Ph.d");
            bool isDr = lastname.StartsWith("Dr");
            System.Console.WriteLine(isPhd);
            System.Console.WriteLine(isDr);
            System.Console.WriteLine(text.ToUpper());
            System.Console.WriteLine(text.ToLower());
            System.Console.WriteLine(text.Trim());
            System.Console.WriteLine(text.Replace("?", ""));


        }
    }
}
