using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503_this
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Motorcycle Case 1
            Motorcycle motorcycle = new Motorcycle(5);
            motorcycle.SetDriverName("Vin");
            motorcycle.PopWheely();
            Console.WriteLine("Case1 ==> Name is {0}",motorcycle.name);

            //Motorcycle Case 2
            Motorcycle1 motorcycle1 = new Motorcycle1(100,"vin");
            Console.WriteLine("Case2 ==> Name is {0}；Speed is {1}",motorcycle1.driverName,motorcycle1.driverIntensity);

            //Motorcycle Case 3
            Motorcycle2 motorcycle2 = new Motorcycle2(9, "test");
            Console.WriteLine("Case3 ==> Name is {0}；Speed is {1}", motorcycle2.driverName, motorcycle2.driverIntensity);

            Console.ReadKey();
        }
    }
}
