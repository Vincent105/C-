using System;
using System.Collections.Generic;
using System.Text;

namespace chapter04
{
    class Class0447
    {
        static void Main()
        {
            char[] cells = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            System.Console.WriteLine("The available moves as follows:");
            foreach (char cell in cells)
            {
                if (cell != '0' || cell != 'x')
                {
                    System.Console.WriteLine($"{cell}");
                }
            }
        }
    }
}
