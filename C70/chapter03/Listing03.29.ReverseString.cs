using System;
using System.Collections.Generic;
using System.Text;

namespace chapter03
{
    class Class0329
    {
        static void Main()
        {
            string reverse, palindrome;
            char[] temp;

            System.Console.Write("Enter the palindrome:");
            palindrome = System.Console.ReadLine();

            reverse = palindrome.Replace(" ", "");
            reverse = reverse.ToLower();

            temp = reverse.ToCharArray();
            System.Array.Reverse(temp);

            if (reverse == new string(temp))
            {
                System.Console.WriteLine($"{palindrome} is a palindrome");
            }
            else 
            {
                System.Console.WriteLine($"{palindrome} is not a palindrome");
            }

        }
    }
}
