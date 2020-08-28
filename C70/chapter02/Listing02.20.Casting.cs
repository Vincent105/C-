using System;
using System.Collections.Generic;
using System.Text;

namespace chapter02
{
    class Class0220
    {
        static void Main0220() 
        {
            unchecked 
            {
                long longNumber = 50918309109;
                int intNumber = (int)longNumber;

                int n = int.MaxValue;
                n = n + 1;

                System.Console.WriteLine("整數值溢位:" + n);
            }

            int intNumber2 = 31416;
            long longNumber2 = (long) intNumber2;

            System.Console.WriteLine("隱式轉型:" + longNumber2);

        }
    }
}
