using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionDeClasesYObjetosAPP
{
    class Employee
    {
        private string firstName;
        private string lastName;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private double bonus;

        public string FirstName
        {
            get { return firstName; }
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

        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                hourlyRate = value;
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
                wage = value;
            }
        }

        public double Bonus
        {
            get { return bonus; }
            set
            {
                bonus = value;
            }
        }

        public Employee(string first, string last, double rate)
        {
            FirstName = first;
            LastName = last;
            HourlyRate = rate;
        }

        public int PerformWork(int hours)
        {
            NumberOfHoursWorked += hours;
            return NumberOfHoursWorked;
        }

        public double ReceiveWage(out int hoursWorked)
        {
            if (bonus > 0)
            {
                Wage = (NumberOfHoursWorked * HourlyRate) + bonus;
                bonus = 0;
            }
            else
            {
                Wage = NumberOfHoursWorked * HourlyRate;
            }            

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");

            NumberOfHoursWorked = 0;
            hoursWorked = NumberOfHoursWorked;

            return Wage;
        }
    }
}
