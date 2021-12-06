using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503_this
{
    internal class Motorcycle2
    {
        public int driverIntensity;
        public string driverName;


        //建構函數鏈
        public Motorcycle2() { }
        public Motorcycle2(int intensity) : this(intensity, "") { }
        public Motorcycle2(string Name) : this(0, Name) { }

        //主要建構函數
        public Motorcycle2(int intensity, string Name)
        {
            if (intensity > 10)
            {
                this.driverIntensity = intensity;
            }
            else
                driverIntensity = intensity;
            driverName = Name;
        }

    }
}
