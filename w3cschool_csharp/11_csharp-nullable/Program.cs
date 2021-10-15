using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_csharp_nullable
{
    class Program
    {
        static void Main(string[] args)
        /*Nullable 與 ?? 合併運算符*/
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolvalue = new bool?();

            Console.WriteLine("顯示可空數值:{0}，{1}，{2}，{3}，{4}", num1, num2, num3, num4, boolvalue);

            double? numtest1 = null;
            double? numtest2 = 3.14157;
            double? numtest3;

            //原值null 將賦值。若numtest1為空，返回第二個操作數值
            numtest3 = numtest1 ?? 5.34;
            Console.WriteLine("{0}", numtest3);
            //原值非null 不賦值。若numtest2不為空，返回第一個操作數值
            numtest3 = numtest2 ?? 5.34;
            Console.WriteLine("{0}", numtest3);
            Console.ReadKey();
        }
    }
}
