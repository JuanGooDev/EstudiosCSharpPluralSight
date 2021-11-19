using CreacionDeClasesYObjetos.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajandoHerencia.HR
{
    public class Employee : IEmployee, IComparable
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;
        public static double taxRate = 0.15;

        private DateTime birthDay;
                       
        

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }


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
                if (value < 0)
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

        public Employee(int id,string first, string last, string em, DateTime bd, double? rate)
        {
            this.Id = id;
            this.FirstName = first;
            this.LastName = last;
            this.Email = em;
            this.BirthDay = bd;
            this.HourlyRate = rate ?? 10;
        }

        //A esto se le conoce como constructor sobrecargado
        //El constructor que tiene los 6 parámetros es el que tiene la palabra reservada : this()
        public Employee(int id ,string first, string last, string em, DateTime bd) : this(id,first, last,
            em, bd, 0)
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

        public double ReceiveWage()
        {

            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmoun = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmoun;


            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;

        }

        /// <summary>
        /// Permite conocer los detalles del Empleado.
        /// </summary>
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\n" +
                                $"\nTax rate: {taxRate}");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public void PerforWork()
        {
            throw new NotImplementedException();
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You´ve done a great job, {FirstName}");
        }

        public int CompareTo(object obj)
        {
            var otherEmploye = (Employee)obj;
            if (Id > otherEmploye.Id)
            {
                return 1;
            }
            else if (Id < otherEmploye.Id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
