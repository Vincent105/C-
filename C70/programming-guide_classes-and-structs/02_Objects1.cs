using System;
using System.Collections.Generic;
using System.Text;

namespace programming_guide_classes_and_structs
{
    class Person02
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person02(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    class Program02
    {
        static void Main()
        {
            Person02 person1 = new Person02("Vincent", 30);
            Console.WriteLine("person1 name is {0} and age is {1}", person1.Name, person1.Age);

            Person02 person2 = person1;
            person2.Name = "Esther";
            person2.Age = 20;

            Console.WriteLine("person1 name is {0} and age is {1}", person1.Name, person1.Age);
            Console.WriteLine("person2 name is {0} and age is {1}", person2.Name, person2.Age);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
