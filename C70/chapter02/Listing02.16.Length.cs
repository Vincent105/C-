using System;
using System.Collections.Generic;
using System.Text;

namespace chapter02
{
    class Class0216
    {
        static void Main0216() 
        {
            string palindrome, upperPalindrome;
            System.Console.Write("Enter the palindrome:");
            palindrome = System.Console.ReadLine();

            System.Console.WriteLine($"The palindrome \"{palindrome}\" is {palindrome.Length} character.");
            
            upperPalindrome = palindrome.ToUpper();
            System.Console.WriteLine(upperPalindrome);
        }
    }
}
