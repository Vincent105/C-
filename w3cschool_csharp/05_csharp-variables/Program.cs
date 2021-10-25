using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_csharp_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100, j, k;
            char c, ch;
            float f, salary;
            double d = 3.14;

            short a1;
            int b1;
            double c1;

            a1 = 10;
            b1 = 20;
            c1 = a1 + b1;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a1, b1, c1);
            Console.ReadKey();

            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num + "is a number");
            Console.ReadKey();
        }
    }
}
