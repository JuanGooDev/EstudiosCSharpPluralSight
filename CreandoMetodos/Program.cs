using System;

namespace CreandoMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingValueParameters();

            Console.ReadLine();
        }

        public static void UsingValueParameters()
        {
            int monthlyWage1 = 1234;
            int monthlyWage2 = 2000;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            int yearlyWageForEmployee1 = CalculateYearlyWage(monthlyWage1, months1, bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");

            int yearlyWageForEmployee2 = CalculateYearlyWage(monthlyWage2, months2,bonus);
            Console.WriteLine($"Yearly wage for employee 2(John): {yearlyWageForEmployee2}");
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {

            if (monthlyWage < 2000)
                bonus *= 2;

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            Console.WriteLine($"The employee got a bonus if {bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        //public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        //{
        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus } ");

        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}

        //public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        //{
        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus } ");

        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}

    }
}
