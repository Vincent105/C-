using System;
using System.Collections.Generic;
using System.Text;

namespace chapter05
{
    class Listing0514
    {
        static void Main()
        {
            string first = "hello";
            string last = "Vin";
            Swap(ref first, ref last);
            Console.WriteLine($"{first} {last}");
        }

        static void Swap(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }
    }
}
