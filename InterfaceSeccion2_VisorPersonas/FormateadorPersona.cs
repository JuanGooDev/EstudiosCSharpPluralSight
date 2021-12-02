using InterfaceSeccion2_Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSeccion2_VisorPersonas
{
    public static class FormateadorPersona
    {
        public static string ToConsoleRecord(this Persona person)
        {
            string output = string.Empty;

            output += $"  {person}  \n";
            output += $"  Rating: {person.Rating}/10     Year: {person.StartDate.Year}\n";
            output += $"----------------------------------";

            return output;
        }
    }
}
