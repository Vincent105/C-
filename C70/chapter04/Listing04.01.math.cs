using System;

namespace chapter04
{
    class Program
    {
        static void Main0401()
        {
            int difference = 4 - 2;
            int numberator, denominator, quotient, remainder;

            System.Console.Write("Enter the numberator:");
            numberator = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the denominator:");
            denominator = int.Parse(System.Console.ReadLine());

            quotient = numberator / denominator;
            remainder = numberator % denominator;

            System.Console.WriteLine($"{numberator} / {denominator} = {quotient} with {remainder}");

            System.Console.WriteLine("t" + difference);

            //加法運用在char
            int n = '3' + '4';
            char c = (char)n;
            System.Console.WriteLine(c);

            //複合賦值
            int x = 123;
            x += 2;
            System.Console.WriteLine(x);
            x -= 2;
            System.Console.WriteLine(x);
            x /= 2;
            System.Console.WriteLine(x);
            x *= 2;
            System.Console.WriteLine(x);
            x %= 2;
            System.Console.WriteLine(x);

            //遞增遞減
            int spaceCount = 0;
            spaceCount = spaceCount + 1;
            spaceCount += 1;
            spaceCount++;
            System.Console.WriteLine("spaceCount++:" + spaceCount);
            
            spaceCount = spaceCount - 1;
            spaceCount -= 1;
            spaceCount--;
            System.Console.WriteLine("spaceCount--:" + spaceCount);

            //遞減示範例子
            char current;
            int unicodeValue;

            current = 'z';

            do
            {
                unicodeValue = current;
                System.Console.WriteLine($"{current}={unicodeValue}\t");

                current--;
            }
            while (current > 'a');
        }
    }
}
