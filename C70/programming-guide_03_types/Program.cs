using System;
using System.Linq;

namespace programming_guide_03_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(a);
            int b = a + 2;
            Console.WriteLine(b);
            bool test = true;
            Console.WriteLine(test);

            float temperature;
            string name;
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source where item <= limit select item;
            Console.WriteLine(query);
        }
    }
}
