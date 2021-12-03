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
            Console.WriteLine("\n=>Methods");
            int x = 9, y = 10;
            Console.WriteLine("Before call: x:{0},y={1}", x, y);
            Console.WriteLine("Answer is:{0}", Add(x, y));
            Console.WriteLine("After call: x:{0},y={1}", x, y);

            Console.WriteLine("\n=>Methods out ");
            int ans1;
            OutAdd1(90, 90, out ans1);
            Console.WriteLine(ans1);

            //out 呼叫一次method，但可以取得多個返回值。
            //out 呼叫時，必須使用out參數。
            //out 如果method使用out參數，必須要將該參數賦值。
            Console.WriteLine("\n=>Methods out");
            int i; string str; bool b;
            OutValues(out i, out str, out b);
            Console.WriteLine("{0},{1},{2}", i, str, b);

            //ref 原變數輸入method後，將改變原本數據。
            Console.WriteLine("\n=>Methods ref");
            string str1 = "test";
            string str2 = "school";
            Console.WriteLine("Before:{0},{1}", str1, str2);
            refSwiftString(ref str1, ref str2);
            Console.WriteLine("Before:{0},{1}", str1, str2);

            //params 
            Console.WriteLine("\n =>Methods params");
            double average;
            average = paramsCalculateAverage(4.0, 3.2, 5, 7, 64.22, 87.2);
            Console.WriteLine(average);

            double[] data = { 4.0, 3.2, 5.7 };
            average = paramsCalculateAverage(data);
            Console.WriteLine(average);

            //SelfDefined 自定義變數，若沒有傳入指定數據時，以預設值回傳。
            Console.WriteLine("\n =>Methods self defined args");
            selfDefinedArgs("test1");
            selfDefinedArgs("test2", "teacher");

            //命名參數，用:指定要輸入的參數，串入參數不需按順序傳入，適用在有許多的 選擇性參數 的情境。
            Console.WriteLine("\n =>Methods");
            DisplayMessage(message: "Hi,Vincent", textColor: ConsoleColor.DarkRed, backgroundcolor: ConsoleColor.White);
            DisplayMessage(textColor: ConsoleColor.DarkBlue, backgroundcolor: ConsoleColor.White, message: "Hi,Esther");
            DisplayMessage(backgroundcolor: ConsoleColor.Yellow, message: "test");
            DisplayMessage(message: "test");

            //函式重載
            Console.WriteLine("\n =>Methods Overload");
            Console.WriteLine("{0}", AddOverLoad(10, 10));
            Console.WriteLine("{0}", AddOverLoad(900000000000000000, 900000000000000000));
            Console.WriteLine("{0}", AddOverLoad(8.1, 7.7));


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

        //引用參數 ref - 傳遞給method前需要初始化。
        public static void refSwiftString(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }

        //參數陣列(可以傳遞多組)
        static double paramsCalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return sum / values.Length;

        }

        //預設參數(可以設定參數的預設值)
        static void selfDefinedArgs(string message, string owner = "Programmer")
        {
            Console.WriteLine(message);
            Console.WriteLine(owner);
        }

        //命名參數(命名後可以不按造順序傳入)
        static void DisplayMessage(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundcolor = ConsoleColor.White, string message = "Default")
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundcolor;

            Console.Write(message);

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;

            Console.Write(message);
        }

        //函式重載
        static int AddOverLoad(int x, int y)
        {
            return x + y;
        }

        static double AddOverLoad(double x, double y)
        {
            return x + y;
        }

        static long AddOverLoad(long x, long y)
        {
            return x + y;
        }

    }
}
