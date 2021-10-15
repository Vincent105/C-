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

            double[] balance = new double[10];
            balance[0] = 4500;

            double[] balance1 = { 220.1, 330, 2 };
            Console.WriteLine("{0}", balance1[0]);

            int[] marks = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("{0}", marks[4]);

            Console.ReadKey();
        }
    }
}
