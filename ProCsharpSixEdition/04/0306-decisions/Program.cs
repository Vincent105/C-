using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0306_decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForeachLoopExample();
            WhileLoopExample();
            IfElseExample();
            SwitchExample();
            Console.ReadKey();
        }

        static void ForLoopExample()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void ForeachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Honda" };
            foreach (string carType in carTypes)
                Console.WriteLine(carType);

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
                Console.WriteLine(i);

        }

        static void WhileLoopExample()
        {
            int countNume = 0;

            while (countNume < 3)
            {
                Console.WriteLine("Loop:{0}", countNume);
                countNume++;
            }
        }

        static void IfElseExample()
        {
            string stringData = "My textual data";
            if (stringData.Length > 0)
            {
                Console.WriteLine("string is greater than 0 charactors.");
            }
        }

        static void SwitchExample()
        {
            Console.WriteLine("1[C#],2[Python]");
            Console.WriteLine("Plz pick your language preference:");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("C#");
                    break;
                case 2:
                    Console.WriteLine("Python");
                    break;
                default:
                    Console.WriteLine("Good");
                    break;
            }
        }
    }
}
