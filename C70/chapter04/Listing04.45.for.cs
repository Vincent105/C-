using System;
using System.Collections.Generic;
using System.Text;

namespace chapter04
{
    class Class0445
    {
        static void Main0445() 
        {
            for (int x = 0, y = 5; ((x <= 5) && ( y >= 0)); y-- , x++ )
            {
                System.Console.WriteLine($"{x}{((x>y) ? '>' : '<')}{y}");
            }


        }

    }
}
