using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_csharp_type_conversion
{
    class Conversion
    {
        static void Main(string[] args)
        {
            //強制轉換double 至 int 
            double d = 567.89;
            int i;

            i = (int)d;
            Console.WriteLine(i);

            //型別轉換
            int i2 = 75;
            float f2 = 53.005f;
            double d2 = 23.7652;
            bool b2 = true;

            Console.WriteLine(i2.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(d2.ToString());
            Console.WriteLine(b2.ToString());

            //類型之間的轉換方法- Convert 和Parse
            string locstr = 123.ToString();
            
            int i3 = Convert.ToInt32(locstr);
            Console.WriteLine(i3);

            int i4 = int.Parse(locstr);
            Console.WriteLine(i4);

            Console.ReadKey();
        }
    }
}
