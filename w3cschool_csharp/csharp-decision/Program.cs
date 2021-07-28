using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_decision
{
    class Program
    {
        static void Main(string[] args)
        {
            //if語句
            int a = 10;

            if (a < 20)
            {
                Console.WriteLine("a < 20");
            }
            else
            {
                Console.WriteLine("a >= 20");
            }
            Console.WriteLine("a的值{0}", a);

            //if else語句
            int b = 100;

            if (b == 10)
            {
                Console.WriteLine("b = 10");
            }
            else if (b == 20)
            {
                Console.WriteLine("b = 20");
            }
            else
            {
                Console.WriteLine("沒有相等的數據");
            }
            Console.WriteLine("b的值{0}", b);

            //嵌套 if
            int a1 = 100;
            int b1 = 200;

            if (a1 == 100)
            {
                if (b1 == 200)
                {
                    Console.WriteLine("a1 = 100 & b1 = 200");
                }
            }

            //switch
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("超強!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("做得好!");
                    break;
                case 'D':
                    Console.WriteLine("再努力!");
                    break;
                default:
                    Console.WriteLine("輸入無效!");
                    break;
            }
            Console.WriteLine("你的成績是{0}", grade);

            //嵌套 switch
            int a2 = 100;
            int b2 = 200;

            switch (a2)
            {
                case 100:
                    Console.WriteLine("這是外部switch");
                    switch (b2)
                    {
                        case 200:
                            Console.WriteLine("這是內部switch");
                            break;
                    }
                    break;
            }
            Console.WriteLine("a2是 {0}", a2);
            Console.WriteLine("b2是 {0}", b2);
            Console.ReadKey();
        }
    }
}
