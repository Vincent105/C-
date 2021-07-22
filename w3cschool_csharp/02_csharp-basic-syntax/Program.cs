using System;

namespace _02_csharp_basic_syntax
{
    class Rectangle
    {
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display() 
        {
            Console.WriteLine("Length:{0}", length);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());
        }

    }

    class ExcuteRectangle 
    {
        static void Main(string[] args) 
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.GetArea();
            r.Display();
            Console.ReadLine();
        }
    }

}
