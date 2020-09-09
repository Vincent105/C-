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
        static void Main02()
        {
            Person02 person1 = new Person02("Vincent", 30);
            Console.WriteLine("person1 name is {0} and age is {1}", person1.Name, person1.Age);

            Person02 person2 = person1;
            person2.Name = "Esther";
            person2.Age = 20;

            Console.WriteLine("person1 name is {0} and age is {1}", person1.Name, person1.Age);
            Console.WriteLine("person2 name is {0} and age is {1}", person2.Name, person2.Age);

            if (person2.Equals(person1))
                Console.WriteLine("person1 and person2 have the same value.");
            else
                Console.WriteLine("person1 and person2 don't have the same value.");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    /*
      Output:
        p1 Name = Vincent Age = 30
        p2 Name = Esther Age = 20
        p1 Name = Esther Age = 20
    */
}
