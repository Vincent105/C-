using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_csharp_string
{
    class Program
    {
        static void Main(string[] args)
        {
            /*字串連結*/
            string fname, lname;
            fname = "Vincent";
            lname = "Wang";

            string fullname = fname + " " + lname;
            Console.WriteLine("Full Name:{0}",fullname);

            /*string建構函數*/
            char[] letters = {'H','e','l','l','o' };
            string greetings = new string(letters);
            Console.WriteLine("Greeting: {0}", greetings);

            /*用方法返回字串*/
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = string.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            DateTime waiting = new DateTime(2012, 10, 10,18,00,55);
            string chat = string.Format("Message sent at {0:t} on {0:d}", waiting);
            Console.WriteLine("Message: {0}",chat);



            Console.ReadKey();
        }
    }
}
