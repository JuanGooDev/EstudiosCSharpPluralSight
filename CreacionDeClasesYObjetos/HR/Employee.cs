using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionDeClasesYObjetos.HR
{
    public class Employee
    {        
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;
        private DateTime birthDay;

        private EmployeeType employeeType;
        public static double taxRate = 0.15;
        private const double maxAmountHoursWorked = 1000;

        public string FirstName
        {
            get 
            {
                return firstName;
            }
            set 
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            set
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get { return wage; }
            set
            {
                if(value < 0)
                {
                    wage = 0;
                }
                else
                {
                    wage = value;
                }
            }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                hourlyRate = value;
            }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set
            {
                birthDay = value;
            }
        }

        public EmployeeType EmployeeType
        {
            get { return employeeType; }
            set
            {
                employeeType = value;
            }
        }

        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType, double? rate)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Email = em;
            this.BirthDay = bd;
            this.EmployeeType = empType;
            this.HourlyRate = rate ?? 10;
        }

        //A esto se le conoce como constructor sobrecargado
        //El constructor que tiene los 6 parámetros es el que tiene la palabra reservada : this()
        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType) : this(first,last,
            em,bd,empType, 0)
        {            
        }

        //Empleado Inicia sus labores
        public void PerformWork()
        {
            this.NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }

        //Hacer que el empleado pare de trabajar
        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        //Recibir salario
        public double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmoun = wageBeforeTax * taxRate;

            wage = wageBeforeTax - taxAmoun;


            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            numberOfHoursWorked = 0;

            return Wage;
        }

        /// <summary>
        /// Permite conocer los detalles del Empleado.
        /// </summary>
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\n" +
                                $"Employee type: {EmployeeType}\nTax rate: {taxRate}");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

    }
}
