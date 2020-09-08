using System;

namespace programming_guide_classes_and_structs
{
    public class Person01
    {
        public Person01()
        {
            Name = "Unknow";
        }

        public Person01(string name)
        {
            Name = name;
        }
        public string Name {get;}

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name;
        }
    }

    class TestPerson
    {
        static void Main01()
        {
            var person1 = new Person01();
            Console.WriteLine(person1.Name);

            Person01 person2 = new Person01("Vincent");
            Person01 person3 = person2;
            Console.WriteLine(person2.Name);

            Console.WriteLine(person2);
            Console.WriteLine(person3);
            Console.WriteLine("Please any key to exit.");
            Console.ReadKey();
        }
    }
}
