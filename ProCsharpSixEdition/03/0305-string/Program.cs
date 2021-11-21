using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0305_string
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunction();
            Console.ReadKey();
        }

        static void BasicStringFunction()
        {
            string firstName = "Vincent";
            Console.WriteLine("{0}", firstName);
            Console.WriteLine("{0}", firstName.Length);
            Console.WriteLine("{0}", firstName.ToUpper());
            Console.WriteLine("{0}", firstName.ToLower());
            Console.WriteLine("{0}", firstName.Contains("i"));
            Console.WriteLine("{0}", firstName.Replace("in",""));
        }
    }
}
