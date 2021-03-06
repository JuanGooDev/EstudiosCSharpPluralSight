using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajandoHerencia.HR
{
    public class Researcher : Employee
    {
        public Researcher(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
        {
        }

        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;
            Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie taste!");
        }
       /* public override double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmoun = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmoun;


            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }*/

    }

    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(int id, string first, string last, string em, DateTime bd, double? rate) : base(id ,first, last, em, bd, rate)
        {
        }
    }

}
