using System;

namespace programming_guide_02_Statements
{
    class Program
    {
        static void Main()
        {
            int counter;

            counter = 1;

            int[] radii = { 15, 22, 44, 55};
            const double pi = 3.14;

            foreach (int radius in radii)
            {
                double cird = pi * radius;

                System.Console.WriteLine("{0}-{1}-{2}", counter, radius, cird);
                counter++;
            }


        }
    }
}
