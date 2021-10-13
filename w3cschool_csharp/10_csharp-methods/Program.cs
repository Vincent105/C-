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

            //值參數傳遞
            Console.WriteLine("交換前的數據a={0},b={1}", r.numr1, r.numr2);
            r.Swap(r.numr1, r.numr2);
            Console.WriteLine("交換後的數據a={0},b={1}", r.numr1, r.numr2);

            //引用參數傳遞
            Console.WriteLine("交換前的數據a={0},b={1}", r.numr1, r.numr2);
            r.Swap_ref(ref r.numr1,ref r.numr2);
            Console.WriteLine("交換後的數據a={0},b={1}", r.numr1, r.numr2);

            //遞迴調用
            Console.WriteLine("6的階乘是{0}", r.factorial(6));
            Console.WriteLine("7的階乘是{0}", r.factorial(7));
            Console.WriteLine("8的階乘是{0}", r.factorial(8));

            Console.ReadKey();
        }
    }

    class NumberManipulator
    {
        public int numr1, numr2, res;
        public int FindMax(int num1, int num2)
        /*比對大小*/
        {
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }

        public void AcceptNum()
        /*讀取數字*/
        {
            Console.WriteLine("請輸入第一個數字:");
            numr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入第二個數字:");
            numr2 = Convert.ToInt32(Console.ReadLine());
        }

        public int factorial(int num)
        /*遞迴方法*/
        {
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        public void Swap(int x,int y)
        /*透過值參數傳，不改變原儲存數據*/
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
            
        }

        public void Swap_ref(ref int x, ref int y)
        /*透過引用參數，將改變原儲存數據*/
        {
            int temp;
            temp = x;
            x = y;
            y = temp; 
        }

    }
}
