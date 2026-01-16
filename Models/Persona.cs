namespace POO.Models
{
    public abstract class Persona
    {
        public string Nombre { get; }
        public string Apellido { get; }
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

        public void CumplirAnios()
        {
            Edad++;
        }
    }
}
