using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0402_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleArray();
            ArrayInitialization();      //初始化陣列
            DeclarVarArray();           //隱式參數陣列
            ArrayObject();              //定義Object陣列
            mutiDimensionArray();       //多緯度陣列
            SystemArrayFunctionality(); //System.Array功能
            Console.ReadKey();
        }

        static void SimpleArray()
        {
            Console.WriteLine("\n Simple Array");
            int[] myInts = new int[3];

            //建立陣列時，int陣列將以預設值0填充數值。
            foreach (int i in myInts)
                Console.WriteLine(i);

            //建立字串陣列時。
            string[] myStrings = new string[100];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
                Console.WriteLine(i);
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("\n Array Initialization");

            //使用New關鍵字初始化陣列
            string[] stringArray = new string[] { "Vin", "Estheer" };
            Console.WriteLine("string has {0} element.", stringArray.Length);

            //不使用New關鍵字初始化陣列
            bool[] boolArray = { true, false, true };
            Console.WriteLine("boolstring has {0} element.", boolArray.Length);

            //使用New關鍵字 指定陣列大小 並初始化陣列
            int[] intArray = new int[3] { 1, 2, 3 };
            Console.WriteLine("intArray has first element:", intArray[0]);

        }

        static void DeclarVarArray()
        {
            //隱式參數陣列 所有元素類型應該要一致。 Var並非System.object
            Console.WriteLine("\n Array DeclarVarArray");

            var a = new[] { "vin", "vin1", "vin2" };
            Console.WriteLine(a.GetType().ToString() + " " + a.ToString());

            var b = new[] { 1, 2, 3 };
            Console.WriteLine(b.GetType().ToString() + " " + b.ToString());
        }

        static void ArrayObject()
        {
            Console.WriteLine("\n ArrayObject");

            object[] objectArray = new object[4];

            objectArray[0] = 100;
            objectArray[1] = "test";
            objectArray[2] = true;
            objectArray[3] = new DateTime(1920, 4, 12);

            foreach (object obj in objectArray)
            {
                Console.WriteLine("Type {0} - Value {1}", obj.GetType(), obj);
            }
        }

        static void mutiDimensionArray()
        {
            Console.WriteLine("\n mutiDimensionArray");

            int[,] matrix = new int[6, 6];

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    matrix[i, j] = i * j;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("\n SystemArrayFunction");

            string[] gothicBands = { "Vin", "Esther", "John" };
            Console.WriteLine("Here is the array:");

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.WriteLine("Name:{0}", gothicBands[i]);
            }

            Console.WriteLine("Clear all but one:");
            Array.Clear(gothicBands, 1, 2);

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.WriteLine("Name:{0}", gothicBands[i]);
            }
        }

    }
}
