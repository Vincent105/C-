using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0401_out_ref_param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=>Methods\n");
            int x = 9, y = 10;
            Console.WriteLine("Before call: x:{0},y={1}", x, y);
            Console.WriteLine("Answer is:{0}", Add(x, y));
            Console.WriteLine("After call: x:{0},y={1}", x, y);

            Console.WriteLine("=>Methods out \n");
            int ans1;
            OutAdd1(90, 90, out ans1);
            Console.WriteLine(ans1);

            //out 呼叫一次method，但可以取得多個返回值。
            //out 呼叫時，必須使用out參數。
            //out 如果method使用out參數，必須要將該參數賦值。
            Console.WriteLine("=>Methods out \n");
            int i; string str; bool b;
            OutValues(out i, out str, out b);
            Console.WriteLine("{0},{1},{2}", i , str, b);

            Console.ReadKey();
        }

        static int Add(int x, int y)
        {
            //按數值傳遞
            int ans = x + y;

            //此處修改的是原本數值的副本。
            x = 1000;
            y = 8888;
            Console.WriteLine("call inside method: x:{0},y={1}", x, y);
            return ans;
        }

        static void OutAdd1(int x1, int y1, out int ans1)
        {
            ans1 = x1 + y1;
        }

        //輸出參數 out - 傳遞給method前不需要初始化，method結束前必須賦值給輸出參數。
        static void OutValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "test";
            c = true;
        }

        //引用參數 ref

    }
}
