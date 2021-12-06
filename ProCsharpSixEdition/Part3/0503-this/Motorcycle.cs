using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503_this
{
    internal class Motorcycle
    {
        public int driverIntensity;
        public string name;

        public Motorcycle(){}

        public Motorcycle(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            else 
                driverIntensity = intensity;
        }

        public void PopWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yee" + "\n");
            }
        }
        public void SetDriverName(string name)
        {
            //name = name;    //對同一個同名變數進行指派，輸入可能導致歧異
            this.name = name;
       
        }
    }
}
