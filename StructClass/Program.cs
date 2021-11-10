using System;

namespace StructClass
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingAStruct();
        }

        /// <summary>
        /// Se crea una variable de tipo empleado la cual permite acceder y asignar valores a las propiedades de esa clase.
        /// </summary>
        private static void UsingAStruct()
        {
            Employee employee;
            employee.Name = "Bethany";
            employee.Wage = 1250;
            employee.Work();
        }

        /// <summary>
        /// Permite crear propiedades y métodos de tipo empleado.
        /// </summary>
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
