using System;
using System.Collections.Generic;
using System.Text;

namespace chapter01
{
    public class HeyYou
    {
        static void Main0114(string[] args) 
        {
            string firstname;
            string lastname;

            System.Console.WriteLine("Hey You");
            System.Console.Write("請輸入姓:");
            firstname = System.Console.ReadLine();

            System.Console.Write("請輸入名:");
            lastname = System.Console.ReadLine();

            System.Console.WriteLine("Your name is " + firstname + lastname);
            System.Console.WriteLine($"Your name is {firstname}{lastname}");

        }
    }
}
