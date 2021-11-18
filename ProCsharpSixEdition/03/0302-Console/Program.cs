using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Console I/O**");
            GetUserData();
            Console.ReadLine();

            Console.ReadKey();
        }

        static void GetUserData()
        {
            Console.WriteLine("Plz enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Plz enter your age:");
            string age = Console.ReadLine();

            ConsoleColor preColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hello {0}! You are {1} years old.", name, age);
            Console.ForegroundColor = preColor;
            Console.WriteLine("Hello {0}! You are {1} years old.", name, age);

            Console.WriteLine("{0},NUMER {0}",9);
            Console.WriteLine("{1},{0},{2}", 10, 20, 30);
        }
    }
}
