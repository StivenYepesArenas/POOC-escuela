namespace POO.Models
{
    public class Alumno
    {
        private int _id;
        private string _nombre = string.Empty;
        private string _apellido = string.Empty;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("El id no puede ser negativo");
                }
                _id = value;
            }
        }
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El nombre no puede ser vacio");
                }
                _nombre = value;
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El apellido no puede ser vacio");
                }
                _apellido = value;
            }
        }

        public Alumno() { }
        public Alumno(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }


        public static void MostrarNombre()
        {
            Console.Write("Hola soy un Alumno y se decir mi nombre");
        }
    }

}