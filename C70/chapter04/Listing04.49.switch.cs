using System;
using System.Collections.Generic;
using System.Text;

namespace chapter04
{
    class Listing04
    {
        public static void Main()
        {
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    System.Console.WriteLine("case 1");
                    break;
                case 2:
                    System.Console.WriteLine("case 2");
                    break;
                default:
                    System.Console.WriteLine("default case");
                    break;
            }
        }
    }
}
