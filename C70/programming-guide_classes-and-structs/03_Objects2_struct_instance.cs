﻿using System;
using System.Collections.Generic;
using System.Text;

namespace programming_guide_classes_and_structs
{
    public struct Person03
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person03(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program03
    {
        static void Main03()
        {
            Person03 p1 = new Person03("Vin", 30);
            Console.WriteLine("p1 name is {0} and age is {1}", p1.Name, p1.Age);

            Person03 p2 = p1;

            p2.Name = "Esther";
            p2.Age = 25;

            Console.WriteLine("p1 name is {0} and age is {1}", p1.Name, p1.Age);
            Console.WriteLine("p2 name is {0} and age is {1}", p2.Name, p2.Age);

            if (p2.Equals(p1))
                Console.WriteLine("person1 and person2 have the same value.");
            else
                Console.WriteLine("person1 and person2 don't have the same value.");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

/*
  Output:
    p1 Name = Vin Age = 30
    p2 Name = Esther Age = 25
    p1 Name = Vin Age = 30
*/
}