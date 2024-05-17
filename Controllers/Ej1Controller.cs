using Microsoft.AspNetCore.Mvc;
using Practica2TN.Entities.Ej1;

namespace Practica2TN.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej1Controller : ControllerBase
    {

        [HttpGet()]

        public List<string> TraerPersonas([FromQuery] string persona1, [FromQuery] string persona2,  [FromQuery] string persona3)
        {
            List<Persona> lista = [];

            lista.Add(new Persona(persona1));
            lista.Add(new Persona(persona2));
            lista.Add(new Persona(persona3));

            List<string> resultado = [];

            foreach(Persona persona in lista) 
            {
                resultado.Add(persona.GetSaludo());
            }
            return resultado;

        }


    }
}
