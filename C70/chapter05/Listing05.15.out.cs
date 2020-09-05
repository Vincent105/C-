using System;
using System.Collections.Generic;
using System.Text;

namespace chapter05
{
    class Listing0515
    {
        static void Main0515()
        {
            int argNumber;
            string argMessage, argDefault;
            Method(out argNumber,out argMessage,out argDefault);
            System.Console.WriteLine(argNumber);
            System.Console.WriteLine(argMessage);
            System.Console.WriteLine(argDefault == null);
        }

        static void Method(out int answer, out string message, out string stillNull)
        {
            answer = 44;
            message = "I've been returned";
            stillNull = null;
        }
    }
}
