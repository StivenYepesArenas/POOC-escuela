namespace POO.Models
{
    public class Alumno : Persona
    {
        public string Codigo { get; private set; }
        public string Grado { get; private set; }
        public int Promedio { get; private set; }
        public bool Activo { get; private set; }

        public Alumno(
            string codigo,
            string nombre,
            string apellido,
            int edad,
            string grado,
            int promedio
        ) : base(nombre, apellido, edad)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código es obligatorio.");

            Codigo = codigo;
            Grado = grado;
            Promedio = promedio;
            Activo = true;
        }

        public void Desactivar()
        {
            Activo = false;
        }

        public void CambiarPromedio(int nuevoPromedio)
        {
            Promedio = nuevoPromedio;
        }
    }
}
