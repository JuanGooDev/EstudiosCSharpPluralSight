using CreacionDeClasesYObjetos.HR;
using System;
using System.Collections.Generic;

namespace CreacionDeClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------");

            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 1000000; i++)
            {
                Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
                    new DateTime(1979, 1, 16), EmployeeType.StoreManager, null);
                employees.Add(randomEmployee);
            }

            employees.Clear();
            employees = null;
            GC.Collect();

            Console.ReadLine();
        }
    }
}
