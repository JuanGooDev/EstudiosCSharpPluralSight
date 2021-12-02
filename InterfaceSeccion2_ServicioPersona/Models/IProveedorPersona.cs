using InterfaceSeccion2_Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSeccion2_ServicioPersona.Models
{
    public interface IProveedorPersona
    {
        List<Persona> GetPeople();
    }
}