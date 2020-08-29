using System;
using System.Collections.Generic;
using System.Text;

namespace chapter03
{
    class Class0318
    {
        static void Main0318()
        {
            //宣告陣列及存取陣列列
            string[] languages1 = new string[6]{ 
              "C#", "COBAL", "Python", 
              "C++", "J#", "Pascal" };

            string talk1 = languages1[4];
            System.Console.WriteLine(talk1);

            //交換陣列中不同位置的資料
            System.Console.WriteLine(languages1[3] +" "+ languages1[2]);
            string talk2 = languages1[3];
            languages1[3] = languages1[2];
            languages1[2] = talk2;
            System.Console.WriteLine(languages1[3] + " " + languages1[2]);

            //初始化二緯陣列 
            int[,] cells = {
                { 1, 0, 2},
                { 0, 2, 0},
                { 1, 2, 1}
            };
            System.Console.WriteLine(cells[1,0]);
            cells[1, 0] = 1;
            System.Console.WriteLine(cells[1, 0]);

            //初始化不規則陣列
            int[][] cells2 = {
                new int[]{ 1, 0, 2},
                new int[]{ 0, 2, 0},
                new int[]{ 1, 2, 1}
            };
            System.Console.WriteLine(cells2[1][0]);
            cells2[1][0] = 1;
            System.Console.WriteLine(cells2[1][0]);

            //長度
            System.Console.WriteLine(languages1.Length);

            string [] languages2 = new string[9];
            languages2[4] = languages2[languages2.Length - 1];

            //排序
            System.Array.Sort(languages1);

            //Array.BinarySearch()
            string searchString = "COBAL";
            int index = System.Array.BinarySearch(languages1,searchString);
            System.Console.WriteLine($"The {searchString} is at index {index}.");
            System.Console.WriteLine();
            System.Console.WriteLine($"{"First Element",-20}\t{"Last Element",-20}");
            System.Console.WriteLine($"{"=============",-20}\t{"============",-20}");
            System.Console.WriteLine($"{languages1[0],-20}\t{languages1[languages1.Length-1],-20}");

            //Array.Reverse()
            System.Array.Reverse(languages1);
            System.Console.WriteLine($"{languages1[0],-20}\t{languages1[languages1.Length - 1],-20}");

            System.Array.Clear(languages1, 0, languages1.Length);
            System.Console.WriteLine($"{languages1[0],-20}\t{languages1[languages1.Length - 1],-20}");
            System.Console.WriteLine(languages1.Length); 


        }
    }
}
