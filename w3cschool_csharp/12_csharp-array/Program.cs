using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_csharp_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int i, j;
            
            /*賦值*/
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /*訪問陣列*/
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}]={1}",j,n[j]);
            }

            /*賦值給陣列*/
            double[] balance = new double[10];
            balance[0] = 4500;
            Console.WriteLine("{0}", balance[0]);

            /*聲明陣列時同時賦值給陣列*/
            double[] balance1 = { 220.1, 330, 2 };
            Console.WriteLine("{0}", balance1[0]);
            
            /*建立時初始化陣列*/
            int[] marks = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("{0}", marks[4]);

            /*將變數賦予其他變數*/
            int[] scores = marks;
            Console.WriteLine("{0}", scores[4]);

            int[] n1 = new int[10];

            /*for each*/
            for (int i2 = 0; i2 < 10; i2++)
            {
                n[i2] = i2 + 100;
            }

            foreach (int j1 in n)
            {
                int i2 = j1 - 100;
                Console.WriteLine("Element[{0}] = {1}", i2, j1);
                i2++;
            }


            Console.ReadKey();
        }
    }
}
