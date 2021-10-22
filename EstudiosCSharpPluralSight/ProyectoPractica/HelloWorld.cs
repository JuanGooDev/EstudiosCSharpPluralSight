using System;
using EstudiosCSharpPluralSight.ProyectoPractica;

namespace EstudiosCSharpPluralSight
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿A dónde deberíamos ir el próximo mes de mayo?");
            WeatherUtilities.Report("Bogota", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Cartagena", WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("Medellín", 23, 65); // ~73 F
        }

    }
}