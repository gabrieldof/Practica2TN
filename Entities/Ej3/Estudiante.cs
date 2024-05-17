namespace Practica2TN.Entities.Ej3
{
    public class Estudiante: Persona
    {
        public Estudiante(int id, string nombre) : base(id, nombre) { }
        public string Estudiar()
        {
            return "Estoy estudiando.";
        }

        public string MostrarEdad()
        {
            return $"Mi edad es: {Edad} años";
        }

        public override string Saludar()
        {
            return $"Hola soy el estudiante {Nombre}";
        }

    }
}
