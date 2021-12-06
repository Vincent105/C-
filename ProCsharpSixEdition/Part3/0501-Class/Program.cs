using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0501_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car 使用new關鍵字，使用預設的建構函數。
            Car myCar = new Car();
            myCar.carName = "Vin";
            myCar.currSpeed = 10;

            for (int i = 0; i < 10; i++)
            {
                myCar.SpeedUp(i);
                myCar.PrintState(); 
            }

            //Car1 有自定義的建構函數
            Car1 myCar2 = new Car1();
            myCar2.PrintState();

            //Car2 定義自定義的建構函數；多型；重載；傳入多組參數控制預設值    
            Car2 myCar31 = new Car2();
            myCar31.PrintState();    
            
            Car2 myCar32 = new Car2("Vin");
            myCar32.PrintState();

            Car2 MyCar33 = new Car2("Vin", 50);
            MyCar33.PrintState();

            Console.ReadKey();
        }
    }
}
