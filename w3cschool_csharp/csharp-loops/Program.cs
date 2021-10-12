using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            
            // while 循環
            while (a < 20) 
            {
                Console.WriteLine("a = {0}", a);
                a++;
            }

            // for 循環
            for (int b = 100; b < 110; b += 1) 
            {
                Console.WriteLine("b = {0}", b);
            }

            // foreach 循環
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13};

            foreach (int element in fibarray) 
            {
                System.Console.WriteLine(element);
            }

            // 類似 foreach 循環
            for (int i = 0; i < fibarray.Length; i++) 
            {
                System.Console.WriteLine(fibarray[i]);
            }

            // do while 循環
            int c = 10;

            do
            {
                Console.WriteLine(" c = {0}", c);
                c += 1;
            } while (c < 20);

            //break 語句
            int d = 10;

            while (d < 20) 
            {
                Console.WriteLine(" d = {0}", d);
                d += 1;
                if (d > 15)
                {
                    break;
                }
            }

            //continue 語句
            int e = 10;

            do
            {
                if (e == 15)
                {
                    e += 1;
                    continue;
                }
                Console.WriteLine("e = {0}", e);
                e++;
            } while (e < 20);


            Console.ReadKey();
        }

    }
}
