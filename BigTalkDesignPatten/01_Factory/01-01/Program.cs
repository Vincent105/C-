using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01
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

                switch (strOperate)
                {
                    case "+":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
                        break;
                    case "-":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                        break;
                    case "*":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                        break;
                    case "/":
                        if (strNumberB != "0")
                            strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                        else
                            strResult = "除數不能為0";
                        break;
                }
                Console.WriteLine("結果是:" + strResult);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("輸入有誤:" + ex.Message);
            }

        }

    }
}
