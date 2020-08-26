using System;

namespace chapter01
{
    public class HelloWorld
    {
        static void Main(string[] args)  
        {
            System.Console.WriteLine("Hello, My name is Vincent");
            System.Console.WriteLine("Up");System.Console.WriteLine("Down"); 
            Console.WriteLine("Hello World1!");
            System.Console.WriteLine(
                "Hello, Your name is Esther.");

            //1.3使用變數
            string max, min; 

            max = "test1";
            System.Console.WriteLine(max);

            min = "test2";
            System.Console.WriteLine(min);

            //
            (string firstname, string lastname) = ("Vincent", "Wang");
            System.Console.WriteLine(firstname + lastname);

            //rewrite
            string valerie;
            string miracleMax = "Have fun storming the castle!";

            valerie = "Think it will work?";

            System.Console.WriteLine(valerie);
            System.Console.WriteLine(miracleMax);

            miracleMax = "It would take a miracle.";
            System.Console.WriteLine(miracleMax);
        }

    }

}
