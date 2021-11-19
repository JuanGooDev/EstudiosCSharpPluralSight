using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajandoHerencia.HR
{
    public class Manager : Employee
    {
        public Manager(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }

        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been an email!");
        }

        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 5)
            {
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 500!");
            }
            else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 250!");
            }
        }

        public override double ReceiveWage()
        {

            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmoun = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmoun;


            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;

        }
    }
}
