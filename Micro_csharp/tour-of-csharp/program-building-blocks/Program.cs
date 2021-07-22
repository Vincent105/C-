using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_building_blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void SwapExample()
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // "2 1"
        }


        public class Color 
        {
            public static readonly Color Black = new Color(0, 0, 0);
            public static readonly Color White = new Color(255, 255, 255);

            public byte R;
            public byte G;
            public byte B;

            public Color (byte r, byte g, byte b) 
            {
                R = r;
                G = g;
                B = b;
            }
        }

        public override string ToString() => "This is an object";
    }
}
