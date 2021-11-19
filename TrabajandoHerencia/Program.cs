using System;
using TrabajandoHerencia.HR;

namespace TrabajandoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager bethany = new Manager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

            Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1979, 1, 16), 30);

            StoreManager kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

            StoreManager kevin = new StoreManager("kevin", "hol", "kevin@snowball.be", new DateTime(1993, 8, 8), 10);

            JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);

            //bethany.DisplayEmployeeDetails();
            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.ReceiveWage();

            //mary.DisplayEmployeeDetails();
            //mary.PerformWork();
            //mary.PerformWork();
            //mary.PerformWork();
            //mary.ReceiveWage();

            //mary.AttendManagementMeeting();

            //bobJunior.ResearchNewPieTastes(10);
            //bobJunior.ReceiveWage();

            //bethany.GiveBonus();
            //mary.GiveBonus();
            //kate.GiveBonus();

            Employee[] employees = new Employee[5];
            employees[0] = bethany;
            employees[1] = mary;
            employees[2] = bobJunior;
            employees[3] = kevin;
            employees[4] = kate;

            foreach (var employee in employees)
            {
                employee.PerformWork();
                employee.ReceiveWage();
                employee.DisplayEmployeeDetails();
                employee.GiveBonus();                
            }

            Console.ReadLine();

        }
    }
}
