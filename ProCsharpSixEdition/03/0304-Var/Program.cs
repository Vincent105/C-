using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            Console.ReadKey();
        }

        static void LocalVarDeclarations()
        {
            int myInt = 1;
            string myString = "This is my data.";
            bool b1 = true, b2 = false, b3 =  true;
            System.Boolean b4 = false;

            Console.WriteLine("{0},{1},{2},{3},{4},{5}",myInt, myString, b1, b2, b3, b4);

            bool b = new bool(); //設置初始值為false
            int i = new int(); //設置為0
            double d = new double();
            DateTime dt = new DateTime();

            Console.WriteLine("{0},{1},{2},{3}", b,i,d,dt);

            Console.WriteLine("{0}", 12.GetHashCode());
            Console.WriteLine("{0}", 12.Equals(23));
            Console.WriteLine("{0}", 12.ToString());
            Console.WriteLine("{0}", 12.GetType());
        }
    }
}
