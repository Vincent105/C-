using System;
using System.Collections.Generic;
using System.Text;

namespace chapter02
{
    class Class0226
    {
        static void Main0226()
        {
            string text = "9.11E-31";
            float kg = float.Parse(text);

            System.Console.WriteLine("使用Parse()進行轉換型別:" + kg);

            string middleText = "261.626";
            double middleC = System.Convert.ToDouble(middleText);
            bool boolen = System.Convert.ToBoolean(middleC);

            System.Console.WriteLine(middleC + "   " + boolen);

            bool boolean = true;
            string text1 = boolean.ToString();
            System.Console.WriteLine("使用ToString()進行轉換型別:" + text1);

            string input;

            System.Console.Write("Enter a number:");
            input = System.Console.ReadLine();
            if (Double.TryParse(input, out double number))
            {
                System.Console.WriteLine($"Your key-in is the {input}.");
            }
            else
            {
                System.Console.WriteLine("not a valid number");
            }
        }
    }
}
