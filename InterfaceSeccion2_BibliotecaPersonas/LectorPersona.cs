using InterfaceSeccion2_Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InterfaceSeccion2_BibliotecaPersonas
{
    public class LectorPersona
    {
        #region Service initializers
        WebClient client = new WebClient();
        string baseUri = "http://localhost:5000";
        JsonSerializerOptions options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        #endregion

        public List<Persona> GetPeople()
        {
            string address = $"{baseUri}/persona";
            string reply = client.DownloadString(address);
            var result = JsonSerializer.Deserialize<List<Persona>>(reply, options);
            if (result is null)
            {
                result = new List<Persona>();
            }
            return result;
        }

        public Persona GetPersona(int id)
        {
            var address = $"{baseUri}/people/{id}";
            string reply = client.DownloadString(address);
            var result = JsonSerializer.Deserialize<Persona>(reply, options);
            if (result is null)
            {
                result = new Persona();
            }
            return result;
        }
    }
}
