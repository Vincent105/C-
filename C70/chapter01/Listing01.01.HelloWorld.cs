using System;

namespace chapter01
{
    public class HelloWorld
    {
        static void Main0101(string[] args)  
        {
            System.Console.WriteLine("Hello, My name is Vincent");
            System.Console.WriteLine("Up");System.Console.WriteLine("Down"); 
            Console.WriteLine("Hello World1!");
            System.Console.WriteLine(
                "Hello, Your name is Esther.");

            //一條語句同時宣告
            string max, min; 

            max = "test1";
            System.Console.WriteLine(max);

            min = "test2";
            System.Console.WriteLine(min);

            (string firstname, string lastname) = ("Vincent", "Wang");
            System.Console.WriteLine(firstname + lastname);

            //更改變數值
            System.Console.WriteLine("=========更改變數值");
            string valerie;
            string miracleMax = "Have fun storming the castle!";

            valerie = "Think it will work?";

            System.Console.WriteLine(valerie);
            System.Console.WriteLine(miracleMax);

            miracleMax = "It would take a miracle.";
            System.Console.WriteLine(miracleMax);

            //賦值再次賦值
            System.Console.WriteLine("=========賦值再次賦值");

            string requirements, miracleMin;
            requirements = miracleMin = "It would take a min miracle.";
            System.Console.WriteLine(requirements);
        }


    }

}
