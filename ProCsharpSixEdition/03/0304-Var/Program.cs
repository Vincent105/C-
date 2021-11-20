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
            UseDateAndTime();
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

            Console.WriteLine("{0}", int.MaxValue);
            Console.WriteLine("{0}", int.MinValue);
            Console.WriteLine("{0}", double.MaxValue);
            Console.WriteLine("{0}", double.MinValue);
            Console.WriteLine("{0}", double.Epsilon);
            Console.WriteLine("{0}", double.PositiveInfinity);
            Console.WriteLine("{0}", double.NegativeInfinity);

            Console.WriteLine("{0}",bool.TrueString);
            Console.WriteLine("{0}",bool.FalseString);

            //型別強制轉換
            Console.WriteLine("=> Data type parsing:");
            bool b11 = bool.Parse("True");
            Console.WriteLine("{0}", b11);
            Console.WriteLine("{0}", b11.GetType());

            double i11 = double.Parse("99.88");
            Console.WriteLine("{0}", i11);
            Console.WriteLine("{0}", i11.GetType());
        }

        static void UseDateAndTime()
        {
            Console.WriteLine("=> Dates and Times:");

            DateTime dt = new DateTime(2021,11,19,01,01,01);
            Console.WriteLine("{0},{1}",dt.Date,dt.DayOfWeek);

            dt = dt.AddDays(30);
            Console.WriteLine("{0}",dt.Day);
        }
    }
}
