using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0404_struct
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;

            public void Increment()
            {
                x++; y++;
            }

            public void Decrement()
            {
                x--; y--;
            }

            public void Display()
            {
                Console.WriteLine("x = {0} ; y = {1}", x, y);
            }
        }

        static void Main(string[] args)
        {
            Point myPoint;
            myPoint.x = 349;
            myPoint.y = 76;
            myPoint.Display();  //使用前必須針對兩個變數進行賦值

            myPoint.Decrement();
            myPoint.Display();

            Point myPoint2 = new Point();   //使用預設建構函數，將兩個變數設定為預設值
            myPoint2.Display();




            Console.ReadKey();


        }
    }
}
