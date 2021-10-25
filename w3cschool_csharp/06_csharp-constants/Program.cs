using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_csharp_constants
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello\tWorld\n\n");

            int a, b;
            a = 10;

            b = (a == 1) ? 20 : 30;
            Console.WriteLine("b = {0}", b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("b = {0}", b);

            Console.ReadKey();
        }
    }
}
