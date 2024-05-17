using Microsoft.AspNetCore.Mvc;
using Practica2TN.Entities.Ej2;
using Practica2TN.Entities.Ej3;

namespace Practica2TN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        private static readonly List<Persona> Personas = new List<Persona>();
        private static int currentId = 1;

        // Método para generar un nuevo ID
        private int GenerateId()
        {
            return currentId++;
        }


        // Endpoint para crear un Estudiante
        [HttpPost("[action]")]
        public ActionResult<Estudiante> CrearEstudiante([FromQuery] string nombre)
        {
            var id = GenerateId();
            var estudiante = new Estudiante(id, nombre);
            Personas.Add(estudiante);
            return Created();
        }

        // Endpoint para crear un Profesor
        [HttpPost("[action]")]
        public ActionResult<Profesor> CrearProfesor([FromQuery] string nombre)
        {
            var id = GenerateId();
            var profesor = new Profesor(id, nombre);
            Personas.Add(profesor);
            return Created();
        }

        // Endpoint para obtener una persona por ID
        [HttpGet("[action]/{id}")]
        public ActionResult<Persona> GetPersona(int id)
        {
            var persona = Personas.FirstOrDefault(p => p.Id == id);
            if (persona == null)
            {
                return NotFound();
            }
            return Ok(persona);
        }

        // Endpoint para que un Estudiante estudie
        [HttpGet("estudiante/{id}/[action]")]
        public ActionResult<string> Estudiar(int id)
        {
            var estudiante = Personas.OfType<Estudiante>().FirstOrDefault(e => e.Id == id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return Ok(estudiante.Estudiar());
        }

        // Endpoint para que un Profesor explique
        [HttpGet("profesor/{id}/[action]")]
        public ActionResult<string> Explicar(int id)
        {
            var profesor = Personas.OfType<Profesor>().FirstOrDefault(p => p.Id == id);
            if (profesor == null)
            {
                return NotFound();
            }
            return Ok(profesor.Explicar());
        }

        // Endpoint para que una persona salude
        [HttpGet("{id}/[action]")]
        public ActionResult<string> Saludar(int id)
        {
            var persona = Personas.FirstOrDefault(p => p.Id == id);
            if (persona == null)
            {
                return NotFound();
            }
            return Ok(persona.Saludar());
        }

        // Endpoint para mostrar la edad de un Estudiante
        [HttpGet("estudiante/{id}/[action]")]
        public ActionResult<string> MostrarEdad(int id)
        {
            var estudiante = Personas.OfType<Estudiante>().FirstOrDefault(e => e.Id == id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return Ok(estudiante.MostrarEdad());
        }

        // Endpoint para establecer la edad de una persona
        [HttpPut("{id}/setEdad/{edad}")]
        public ActionResult SetEdad(int id, int edad)
        {
            var persona = Personas.FirstOrDefault(p => p.Id == id);
            if (persona == null)
            {
                return NotFound();
            }
            persona.SetEdad(edad);
            return NoContent();
        }








        [HttpGet("[action]")]
        // Este método muestra todo por consola... 
        public void GetStatusEstudiante()
        {
            //Persona persona = new Persona();
            //persona.Saludar();

            //Estudiante estudiante = new Estudiante();
            //estudiante.SetEdad(20);
            //estudiante.Saludar();
            //estudiante.MostrarEdad();
            //estudiante.Estudiar();

            //Profesor profesor = new Profesor();
            //profesor.SetEdad(40);
            //profesor.Saludar();
            //profesor.Explicar();


        }

        //[HttpPost("[action]")]
        //public ActionResult<string> SetEdadEstudiante([FromBody] int edad)
        //{
        //    Estudiante estudiante = new Estudiante();
        //    estudiante.SetEdad(edad);

        //    return Ok($"{estudiante.MostrarEdad}");

        //}


        //[HttpPost("[action]")]
        //public ActionResult<string> SetEdadProfesor([FromBody] int edad)
        //{
        //    Profesor profesor = new Profesor();
        //    profesor.SetEdad(edad);

        //    return Ok($"Soy Profesor y mi edad es: {profesor.edad}");


        //}


        //[HttpGet("[action]")]
        //public ActionResult<string> GetSaludoEstudiante()
        //{
        //    Estudiante estudiante = new Estudiante();
            

        //    return Ok(estudiante.Saludar);

        //}


        //[HttpGet("[action]")]
        //public ActionResult<string> GetSaludoProfesor()
        //{
        //    Profesor profesor = new Profesor();
        //      return Ok($"{profesor.Saludar}");


        //}

    }
}
