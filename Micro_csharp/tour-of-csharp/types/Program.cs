using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(10, 20);


            var pair = new Pair<int, string>(1, "two");
            int i = pair.First;
            string s = pair.Second;

            Console.WriteLine(i);
            Console.WriteLine(s);

            //衍生類別
            Point a = new Point(3, 2);
            Point b = new Point3D(3, 2, 1);
            Point3D c = new Point3D(3, 2, 1);

            //列舉
            var turnip = SomeRootVegetable.Turnip;
            var spring = Seasons.Spring;
            var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
            var theYear = Seasons.All;

            Console.WriteLine(turnip);
            Console.WriteLine(spring);
            Console.WriteLine(startingOnEquinox);
            Console.WriteLine(theYear);

            //Nullable type
            int? optionInt = default;
            Console.WriteLine(optionInt);
            optionInt = 5;
            Console.WriteLine(optionInt);

            //Tuple 元組
            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} element is {t2.Sum}");

            Console.ReadKey();

        }

        //Base classes 基底類別
        public class Point 
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y) => (X, Y) = (x, y);
        }

        //type parameter 型別參數
        public class Pair<TFirst, TSecond>
        {
            public TFirst First { get; }
            public TSecond Second { get; }

            public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);
        }

        //Derived classes 衍生類別
        public class Point3D : Point
        { 
            public int Z { get; }

            public Point3D(int x, int y, int z) : base(x, y)
            {
                Z = z;
            }
        }

        //struct 結構
        public struct Point_struct
        {
            public double X { get; }
            public double Y { get; }

            public Point_struct(double x, double y) => (X, Y) = (x, y);

        }

        //interface 介面
        //先跳過

        //Enums 列舉
        public enum SomeRootVegetable
        { 
            HorseRadish,
            Radish,
            Turnip
        }

        public enum Seasons
        { 
            none = 0,
            Summer = 1,
            Autumn = 2,
            Winter = 4,
            Spring = 8,
            All = Summer | Autumn | Winter | Spring
        }

    }
}
