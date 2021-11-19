﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajandoHerencia.HR
{
    public class StoreManager:Employee
    {
        public StoreManager(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
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