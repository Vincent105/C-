using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0305_string
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunction();
            StringConcatenation();
            EscapeChars();
            StringEquality();
            StringBuilder();
            LingQueryOverInts();
            Console.ReadKey();
        }

        static void BasicStringFunction()
        {
            Console.WriteLine("=>Basic String:");
            string firstName = "Vincent";
            Console.WriteLine("{0}", firstName);
            Console.WriteLine("{0}", firstName.Length);
            Console.WriteLine("{0}", firstName.ToUpper());
            Console.WriteLine("{0}", firstName.ToLower());
            Console.WriteLine("{0}", firstName.Contains("i"));
            Console.WriteLine("{0}", firstName.Replace("in", ""));
        }

        static void StringConcatenation()
        {
            Console.WriteLine("=>Sting Concatenation:");
            string s1 = "Programming the ";
            string s2 = "Csharp";
            string s3 = s1 + s2;
            string s4 = string.Concat(s1, s2);

            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\"");
            Console.WriteLine("C:\\MyApp\\Bin\\Debug");

            //逐字字元符號
            Console.WriteLine(@"C:\MyApp\Bin\Debug");

        }

        static void StringEquality()
        {
            Console.WriteLine("=> String Equality:");
            string s11 = "Hello!";
            string s12 = "Yo!";

            Console.WriteLine("s11={0}", s11);
            Console.WriteLine("s12={0}", s12);

            Console.WriteLine("s11=s12:{0}", s11 == s12);
            Console.WriteLine("s11=Hello!:{0}", s11 == "Hello!");
            Console.WriteLine("s11=HELLO!:{0}", s11 == "HELLO!");
            Console.WriteLine("s11.equals(s12):{0}", s11.Equals(s12));
            Console.WriteLine("Yo!.equals(s12):{0}", "Yo!".Equals(s12));

        }

        static void StringBuilder()
        {
            Console.WriteLine("=> String Builder:");
            StringBuilder sb = new StringBuilder("Fantastic Games");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Desus" + "2");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", "3");
            Console.WriteLine(sb.ToString());
        }

        static void LingQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            var subset = from i in numbers where i < 10 select i;

            Console.WriteLine("Values in subset:");
            foreach (var i in subset)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Subset is a {0}",subset.GetType().Name);
            Console.WriteLine("Subset is defined in {0}", subset.GetType().Namespace);
        }
    }
}
