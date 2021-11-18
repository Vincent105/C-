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
            FormatNumbericalData();
            DisplayMessage();
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

        static void FormatNumbericalData()
        {
            Console.WriteLine("The value 9999 in various formats");
            Console.WriteLine("c format: {0:c}",9999);
            Console.WriteLine("d format: {0:d9}", 9999);
            Console.WriteLine("f format: {0:f3}", 9999);
            Console.WriteLine("n format: {0:n}", 9999);
        }

        static void DisplayMessage()
        {
            string userMessage = string.Format("10000 in hex is {0:x}", 10000);

            System.Windows.MessageBox.Show(userMessage);


        }
    }
}
