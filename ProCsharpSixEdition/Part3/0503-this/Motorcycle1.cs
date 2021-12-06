using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503_this
{
    internal class Motorcycle1
    {
        public int driverIntensity;
        public string driverName;

        public Motorcycle1() { }
        public Motorcycle1(int intensity)
        {
            setIntensity(intensity);
        }

        public Motorcycle1(int intensity, string name)
        {
            setIntensity(intensity);
            this.driverName = name;
        }

        public void setIntensity(int intensity)
        {
            if (intensity > 10)
            {
                this.driverIntensity = 10;
            }
            else
                this.driverIntensity = intensity;
        }
    }
}
