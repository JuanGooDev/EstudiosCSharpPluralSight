using System;
using System.Collections.Generic;

namespace CreacionDeClasesYObjetosAPP
{
    class Program
    {
        private static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************************");
            Console.WriteLine("* Bethany's Pie Shop Employee App *");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string userSelection;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("********************");
                Console.WriteLine("* Select an action *");
                Console.WriteLine("********************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1: Register employee");
                Console.WriteLine("2: Register work hours for employee");               
                Console.WriteLine("3: Pay employee");
                Console.WriteLine("4: Update HourlyRate");
                Console.WriteLine("5: Give a bonus");
                Console.WriteLine("9: Quit application");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        RegisterEmployee();
                        break;
                    case "2":
                        RegisterWork();
                        break;
                    case "3":
                        PayEmployee();
                        break;
                    case "4":
                        UpdateHoulyRate();
                        break;
                    case "5":
                        GiveBonus();
                        break;
                    case "9": break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
            while (userSelection != "9");

            Console.WriteLine("Thanks for using the application");
            Console.Read();

        }
       
        private static void RegisterEmployee()
        {
            Console.WriteLine("Creating an employee");
            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the hourly rate: ");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);//we will assume here that input is in the correct format

            Employee employee = new Employee(firstName, lastName, rate);
            employees.Add(employee);

            Console.WriteLine("Employee created!\n\n");
        }

        private static void RegisterWork()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }

            int selection = int.Parse(Console.ReadLine());//we will assume here that a valid ID is selected

            Console.Write("Enter the number of hours worked: ");
            int hours = int.Parse(Console.ReadLine());//we will assume here that a valid amount was entered

            Employee selectedEmployee = employees[selection - 1];
            int numberOfHoursWorked = selectedEmployee.PerformWork(hours);
            Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has now worked {numberOfHoursWorked} hours in total.\n\n");
        }

        private static void PayEmployee()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }

            int selection = int.Parse(Console.ReadLine());//we will assume here that a valid ID is selected

            Employee selectedEmployee = employees[selection - 1];
            int hoursWorked;
            double receivedWage = selectedEmployee.ReceiveWage(out hoursWorked);

            Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has received a wage of {receivedWage}. The hours worked is reset to {hoursWorked}.\n\n");
        }

        private static void UpdateHoulyRate()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }

            int selection = int.Parse(Console.ReadLine()); //Seleccionamos el empleado para actualizar el pago por hora.

            Employee selectedUpdateEmployee = employees[selection - 1];

            Console.Write("Enter the new hourly Rate: ");

            int newhourlyRate = int.Parse(Console.ReadLine());

            selectedUpdateEmployee.HourlyRate = newhourlyRate;

            Console.WriteLine($"{selectedUpdateEmployee.FirstName} {selectedUpdateEmployee.LastName} has a new Hourly Rate {selectedUpdateEmployee.HourlyRate}. \n\n");
        }

        private static void GiveBonus()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }

            int selection = int.Parse(Console.ReadLine());

            Employee employeeSelected = employees[selection - 1];

            Console.Write("Enter Bonus of employee: ");

            int bonus = int.Parse(Console.ReadLine());

            employeeSelected.Bonus = bonus;

            Console.WriteLine($"The Employee {employeeSelected.FirstName} {employeeSelected.LastName} received a bonus of {bonus}");

        }
    } 

}
