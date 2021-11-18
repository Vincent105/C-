using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("請輸入數字A: ");
                string strNumberA = Console.ReadLine();
                Console.Write("請選擇運算符號(+、-、*、/): ");
                string strOperate = Console.ReadLine();
                Console.Write("請輸入數字B: ");
                string strNumberB = Console.ReadLine();
                string strResult = "";

                strResult = Convert.ToString(Operation.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));

                Console.WriteLine("結果是:" + strResult);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("輸入有誤:" + ex.Message);
            }

        }
    }

    public class Operation
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;
            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
            }
            return result;
        }
    }
}
