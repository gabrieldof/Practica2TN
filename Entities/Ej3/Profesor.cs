namespace Practica2TN.Entities.Ej3
{
    public class Profesor : Persona
    {
        public Profesor(int id, string nombre) : base(id, nombre) { }
        public string Explicar()
        {
            return "Estoy explicando.";
        }

        public override string Saludar()
        {
            return $"Hola soy el profesor {Nombre}";
        }
    }
}
