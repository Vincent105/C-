using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_csharp_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberManipulator r = new NumberManipulator();
            r.AcceptNum();
            r.res = r.FindMax(r.numr1, r.numr2);
            Console.WriteLine("{0} and {1}當中{2}數值最大", r.numr1, r.numr2, r.res);
            Console.ReadKey();
        }
    }

    class NumberManipulator
    {
        public int numr1, numr2, res;
        public int FindMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;

        }

        public void AcceptNum()
        {
            Console.WriteLine("請輸入第一個數字:");
            numr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入第二個數字:");
            numr2 = Convert.ToInt32(Console.ReadLine());

        }
    }
}
