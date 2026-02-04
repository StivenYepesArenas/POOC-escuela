namespace POO.Models
{
    public abstract class Persona
    {
        public string Nombre { get; private set;}
        public string Apellido { get; private set;}
        public int Edad { get; private set; }

        protected Persona(string nombre, string apellido, int edad)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El apellido es obligatorio.");

            if (edad < 0)
                throw new ArgumentOutOfRangeException(nameof(edad));

            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public void UpdateBasicData(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;    
            Edad = edad;
        }
    }
}
