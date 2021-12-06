using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0501_Class
{
    internal class Car1
    {
        //Car類別的成員
        public string carName;
        public int currSpeed;

        public Car1()
        {
            carName = "Esther";
            currSpeed = 1000;
        }

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPh.", carName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
