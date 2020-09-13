using System;
using System.Collections.Generic;
using System.Text;

namespace programming_guide_02_Statements
{
    public class Person0201
    {
        public Person0201(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }
        private string fname;
        private string lname;

        public override string ToString() => $"{fname}-{lname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());

        public class Location
        {
            private string locationName;

            public Location(string name) => locationName = name;
            public string Name
            {
                get => locationName;
                set => locationName = value;
            }
        }
}

    class Example0201
    {
        static void Main()
        {
            Person0201 p = new Person0201("Vincent", "Wang");
            Console.WriteLine(p);
            p.DisplayName();
        }

    }

}



 