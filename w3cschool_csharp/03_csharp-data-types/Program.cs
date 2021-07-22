using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_csharp_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int:{0}", sizeof(int));

            ///引用類型（Reference types）
            /*物件型別:（Object）類型可以被分配任何其他類型（值類型、引用類型、預定義類型或用戶自定義類型）的值。*/
            object obj;
            obj = 100;
            Console.WriteLine(obj);

            //Boxing
            int val = 8;
            object obj2 = val;
            Console.WriteLine(obj2);

            //UnBox （Object）在分配值之前，需要先進行類型轉換。
            int val2 = (int)obj2;

            //動態（Dynamic）類型
            dynamic a = 20;

            //字符串（String）類型
            String str2 = @"C:\test";
            String str3 = "C:\\test";

            Console.WriteLine(str2);
            Console.WriteLine(str3);

            Console.ReadKey();
        }
    }
}
