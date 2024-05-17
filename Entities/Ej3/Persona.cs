namespace Practica2TN.Entities.Ej3
{
    public class Persona
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public virtual string Saludar()
        {
            return $"Hola, soy {Nombre}";
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }

    }
}
