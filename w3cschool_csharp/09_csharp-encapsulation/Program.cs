using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_csharp_encapsulation
{
    class ExcuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle_public r = new Rectangle_public();
            r.length = 4;
            r.width = 3;
            r.Display();
            Console.WriteLine("===Rectangle_public=========");

            Rectangle_private r1 = new Rectangle_private();
            r1.Acceptdetails();
            r1.Display();
            Console.WriteLine("===Rectangle_private=========");

            Rectangle_internal r2 = new Rectangle_internal();
            r2.length2 = 20;
            r2.width2 = 10;
            r2.Display();
            Console.WriteLine("===Rectangle_internal=========");
            Console.ReadKey();
        }
    }
    class Rectangle_public
    {
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("長度: {0}", length);
            Console.WriteLine("寬度: {0}", width);
            Console.WriteLine("面積: {0}", GetArea());
        }


    }

    class Rectangle_private
    {
        private double length1;
        private double width1;

        public void Acceptdetails()
        {
            Console.WriteLine("請輸入長度:");
            length1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入寬度:");
            width1 = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length1 * width1;
        }
        public void Display()
        {
            Console.WriteLine("長度: {0}", length1);
            Console.WriteLine("寬度: {0}", width1);
            Console.WriteLine("面積: {0}", GetArea());
        }


    }

    class Rectangle_internal
    {
        internal double length2;
        internal double width2;

        //成員函數 如果沒有指定訪問修飾符，則使用類成員的默認訪問修飾符private
        double GetArea()
        {
            return length2 * width2;
        }
        public void Display()
        {
            Console.WriteLine("長度: {0}", length2);
            Console.WriteLine("寬度: {0}", width2);
            Console.WriteLine("面積: {0}", GetArea());
        }

    }
}
