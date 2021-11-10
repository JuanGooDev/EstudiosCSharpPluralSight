
namespace EnumerationClass
{
    using System;

    /// <summary>
    /// En esta clase se desarrollarán ejemplos relacionados a Tipos de sistemas y tipos personalizados
    /// de sistemas.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            UsingEnumerations();

            Console.ReadLine();
        }

        private static void UsingEnumerations()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;
            int baseWage = 1000;

            CalculateWage(baseWage, employeeType, storeType);
        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculatedWage = 0;
            Console.WriteLine($"Employee type: {employeeType}");
            Console.WriteLine($"Store type: {storeType}");

            if (employeeType == EmployeeType.Manager)
            {
                calculatedWage = baseWage * 3;
            }
            else
            {
                calculatedWage *= 2;
            }

            if (storeType == StoreType.FullPieRestaurant)//Larger retail point so give a bonus
                calculatedWage += 500;


            Console.WriteLine($"The calculated wage is {calculatedWage}");
        }

    }

    enum EmployeeType
    {
        Sales,//0
        Manager,//1
        Research,//2
        StoreManager//3
    }

    enum StoreType
    {
        PieCorner = 10,
        Seating = 20,
        FullPieRestaurant = 100,
        Undefined = 99
    }
}
