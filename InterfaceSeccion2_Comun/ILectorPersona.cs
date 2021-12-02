using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeccion2_Comun
{
    public interface ILectorPersona
    {
        IEnumerable<Persona> GetPeople();
        Persona GetPerson(int id);
    }
}
