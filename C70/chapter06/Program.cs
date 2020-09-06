namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_14
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            Employee employee1;

            Employee employee2 = new Employee();
            employee2.SetName("Inigo", "Montoya");
            employee2.Save();

            // Modify employee2 after saving
            IncreaseSalary(employee2);

            // Load employee1 from the saved version of employee2
            employee1 = DataStorage.Load("Inigo", "Montoya");

            Console.WriteLine(
                $"{ employee1.GetName() }: { employee1.Salary }");
        }

        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }

    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary;

        public string GetName()
        {
            return $"{ FirstName } { LastName }";
        }

        public void SetName(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine(
                $"Name changed to '{ this.GetName() }'");
        }

        public void Save()
        {
            DataStorage.Store(this);
        }
    }

    class DataStorage
    {
        public static void Store(Employee employee)
        {
            FileStream stream = new FileStream(
                employee.FirstName + employee.LastName + ".dat",
                FileMode.Create);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);

            writer.Dispose();  // Automatically closes the stream
        }

        public static Employee Load(string firstName, string lastName)
        {
            Employee employee = new Employee();

            FileStream stream = new FileStream(
                firstName + lastName + ".dat", FileMode.Open);

            StreamReader reader = new StreamReader(stream);

            employee.FirstName = reader.ReadLine();
            employee.LastName = reader.ReadLine();
            employee.Salary = reader.ReadLine();

            reader.Dispose();  // Automatically closes the stream

            return employee;
        }
    }

}
