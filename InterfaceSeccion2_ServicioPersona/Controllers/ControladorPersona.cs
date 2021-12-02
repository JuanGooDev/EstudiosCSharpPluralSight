using InterfaceSeccion2_Comun;
using InterfaceSeccion2_ServicioPersona.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSeccion2_ServicioPersona.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControladorPersona : ControllerBase
    {
        private readonly ILogger<ControladorPersona> _logger;
        private readonly IProveedorPersona _proveedor;

        public ControladorPersona(IProveedorPersona proveedor, ILogger<ControladorPersona> logger)
        {
            _proveedor = proveedor;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return _proveedor.GetPeople();
        }

        [HttpGet("{id}")]
        public Persona Get(int id)
        {
            return _proveedor.GetPeople().First(p => p.Id == id);
        }
    }
}
