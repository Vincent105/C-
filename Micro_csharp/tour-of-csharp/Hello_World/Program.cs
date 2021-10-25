using System;
using Acme.Collections;

namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit.");

            int a = 10;
            Console.WriteLine(a);

            var s = new Stack<int>();
            s.Push(1); // stack contains 1
            s.Push(10); // stack contains 1, 10
            s.Push(100); // stack contains 1, 10, 100
            Console.WriteLine("POP1:" + s.Pop()); // stack contains 1, 10
            Console.WriteLine("POP2:" + s.Pop()); // stack contains 1
            Console.WriteLine("POP3:" + s.Pop()); // stack is empty
            Console.ReadKey();
        }
    }
}