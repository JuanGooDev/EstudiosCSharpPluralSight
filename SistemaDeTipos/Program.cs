using System;

namespace SistemaDeTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string fullname1 = firstName + " " + lastName;
            string fullname = $"Su nombre es: {firstName}  {lastName}";
            string employeeIdentification = string.Concat(firstName, lastName);

            string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

            int length = empId.Length;

            if (fullname.Contains("beth") || fullname.Contains("Beth"))
            {
                Console.WriteLine("It's Bethany!");
            }

            string subString = fullname.Substring(1, 3);
            Console.WriteLine("Chararters 2 to 4 of fullName are " + subString);


            //Escaping Text
            string displayName = $"Welcome!\n{firstName}\t{lastName}";

            Console.WriteLine(displayName);

            string invalidFilePath = "C:\\data\\employeelist.xlsx";

            string marketingTagLine = "Baking the \"best pies\" ever";

            string verbatimFilePath = @"C:\data\employeelist.xlsx";


            //Comparaciones de strings
            string name1 = "Bethany";
            string name2 = "BETHANY";

            Console.WriteLine("Are both names equal? " + (name1 == name2));
            Console.WriteLine("Are both names equal? " + (name1 == "Bethany"));
            Console.WriteLine("Are both names equal? " + (name1.Equals(name2)));
            Console.WriteLine("Are both names equal? " + (name2.ToLower() == "bethany"));

            //Los Strings son immutables
            string name = "Bethany";
            string anotherName = name;

            name += " Smith";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Another name: " + anotherName);


            //Parsing strings
            Console.WriteLine("Enter the wage");
            string wage = Console.ReadLine();

            //int wageValue = int.Parse(wage);

            int wageValue;
            if (int.TryParse(wage, out wageValue))
            {
                Console.WriteLine("Parsing success: " + wageValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }

            Console.ReadLine();

        }
    }
}
