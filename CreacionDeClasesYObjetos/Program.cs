using System;

namespace CreacionDeClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------");

            Employee juan = new Employee("Juan","Gómez","juan50cent@live.com", new DateTime(1998,04,07),EmployeeType.Manager, 25);

            Employee george = new Employee("George", "Martinez", "george@live.com", new DateTime(1991, 04, 07), EmployeeType.Research, 30);

            juan.HourlyRate = 50;
            juan.NumberOfHoursWorked = 100;
            juan.Wage = -10;

            juan.DisplayEmployeeDetails();
            juan.PerformWork();
            juan.PerformWork();
            juan.PerformWork();
            juan.PerformWork();
            juan.ReceiveWage();

            george.DisplayEmployeeDetails();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();

            Console.ReadLine();
        }
    }
}
