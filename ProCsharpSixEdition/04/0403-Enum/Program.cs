using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403_Enum
{
    internal class Program
    {
        //Enum 預設值
        enum EmpType
        {
            Manager,        // = 0
            Grunt,          // = 1
            Contractor,     // = 2
            VicePresident   // = 3
        }

        //Enum 調整預設值
        enum EmpTypeTest
        {
            Manager = 102,        // = 102
            Grunt,                // = 103
            Contractor,           // = 104
            VicePresident         // = 105
        }

        //Enum 給定不定值
        enum EmpTypeTest2 : byte
        {
            Manager = 10,         // = 10
            Grunt = 1,            // = 1
            Contractor = 100,     // = 100
            VicePresident = 9      // = 9
        }

        static void Main(string[] args)
        {
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor color = ConsoleColor.Green;

            Console.WriteLine("Fun with Enum");
            EmpType emp = EmpType.Contractor;
            
            AskForBonus(emp);                       //用Enum作為參數
            WriteEumnType(emp);                     //示範Enum method
            EveluateEnum(emp);                      //示範Enum method取得列舉的所有資訊
            EveluateEnum(day);
            EveluateEnum(color);

            Console.ReadKey();
        }

        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("HI Manager");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("HI Grunt");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("HI contractor");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Hi VicePresident");
                    break;
            }
        }

        static void WriteEumnType(EmpType emp)
        {
            Console.WriteLine(Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine(Enum.GetUnderlyingType(typeof(EmpType)));
            Console.WriteLine("emp is a {0}",emp.ToString());           //取得名稱
            Console.WriteLine("emp is a {0}",(int)emp);                 //取得數值
        }

        static void EveluateEnum(Enum e)
        {
            Console.WriteLine(e.GetType().Name);
            Console.WriteLine(Enum.GetUnderlyingType(e.GetType()));

            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine(enumData.Length);

            for (int i = 0; i < enumData.Length; i++)
            {
                //使用format的D格式
                Console.WriteLine("Name:{0},Value:{0:D}",enumData.GetValue(i));   
            }
        }


    }
}
