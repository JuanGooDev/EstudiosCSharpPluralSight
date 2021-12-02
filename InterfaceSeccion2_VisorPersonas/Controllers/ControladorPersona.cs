using InterfaceSeccion2_BibliotecaPersonas;
using InterfaceSeccion2_Comun;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSeccion2_VisorPersonas.Controllers
{
    public class ControladorPersona : Controller
    {
        /// <summary>
        /// Nuevo objeto de la clase LectorPersona
        /// </summary>
        LectorPersona reader = new LectorPersona();

        /// <summary>
        /// Este método se alinea con los enlaces de nuestro sitio web
        /// </summary>
        /// <returns></returns>
        public IActionResult UseConcreteType()
        {
            List<Persona> persona = reader.GetPeople();

            ViewData["Title"] = "Using Concrete Type";

            //Para utilizar la variable persona la pasaremos a nuestra vista
            return View("Index", persona);
        }

        /// <summary>
        /// Este método se alinea con los enlaces de nuestro sitio web
        /// </summary>
        /// <returns></returns
        public IActionResult UseAbstractType()
        {
            IEnumerable<Persona> persona = reader.GetPeople();

            ViewData["Title"] = "Using Abstract Type";
            return View("Index", persona);
        }
    }
}
