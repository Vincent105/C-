using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0501_Class
{
    internal class Car2
    {
        public string carName;
        public int currSpeed;

        public Car2()
        {
            carName = "Esther";
            currSpeed = 10;
        }

        public Car2(string cn)
        {
            carName = cn;
        }

        public Car2(string cn, int cs)
        {
            carName = cn;
            currSpeed = cs;
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
