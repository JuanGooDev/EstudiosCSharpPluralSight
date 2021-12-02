using InterfaceSeccion2_Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSeccion2_ServicioPersona.Models
{
    public class ProveedorPersonaCodificada : IProveedorPersona
    {
        public List<Persona> GetPeople()
        {
            var p = new List<Persona>()
            {
                new Persona() { Id=1, GivenName="John", FamilyName="Koenig",
                    StartDate = new DateTime(1975, 10, 17), Rating=6 },
                new Persona() { Id=2, GivenName="Dylan", FamilyName="Hunt",
                    StartDate = new DateTime(2000, 10, 2), Rating=8 },
                new Persona() { Id=3, GivenName="Leela", FamilyName="Turanga",
                    StartDate = new DateTime(1999, 3, 28), Rating=8,
                    FormatString = "{1} {0}" },
                new Persona() { Id=4, GivenName="John", FamilyName="Crichton",
                    StartDate = new DateTime(1999, 3, 19), Rating=7 },
                new Persona() { Id=5, GivenName="Dave", FamilyName="Lister",
                    StartDate = new DateTime(1988, 2, 15), Rating=9 },
                new Persona() { Id=6, GivenName="Laura", FamilyName="Roslin",
                    StartDate = new DateTime(2003, 12, 8), Rating=6},
                new Persona() { Id=7, GivenName="John", FamilyName="Sheridan",
                    StartDate = new DateTime(1994, 1, 26), Rating=6 },
                new Persona() { Id=8, GivenName="Dante", FamilyName="Montana",
                    StartDate = new DateTime(2000, 11, 1), Rating=5 },
                new Persona() { Id=9, GivenName="Isaac", FamilyName="Gampu",
                    StartDate = new DateTime(1977, 9, 10), Rating=4 },
            };
            return p;
        }
    }
}
