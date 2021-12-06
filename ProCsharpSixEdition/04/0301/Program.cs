using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****My First C# App*****");
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", Environment.Version);

            Console.ReadKey();
        }
    }
}
