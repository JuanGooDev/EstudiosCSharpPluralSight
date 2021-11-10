using System;

namespace StructClass
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingAStruct();
        }

        private static void UsingAStruct()
        {
            Employee employee;
            employee.Name = "Bethany";
            employee.Wage = 1250;
            employee.Work();
        }

        struct Employee
        {
            public string Name;
            public int Wage;

            public void Work()
            {
                Console.WriteLine($"{Name} is now doing work!");
            }
        }

    }
}
