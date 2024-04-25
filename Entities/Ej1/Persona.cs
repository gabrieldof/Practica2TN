using System.Diagnostics.Contracts;

namespace Practica2TN.Entities.Ej1
{
    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre) 
        { 
             Nombre = nombre;
        }

        public string GetSaludo() 
        { 
            return $"hola mi nombre es {Nombre}"; 
        }

 
    }
}
