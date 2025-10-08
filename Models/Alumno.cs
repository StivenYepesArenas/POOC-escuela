namespace POO.Models
{
    public class Alumno : Persona
    {
        private int _id;
        public Alumno() { }
        
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
        public Alumno( int edad, string nombre, int id) : base(edad, nombre)
        {
            Id = id;
        }
        public override void Saludar()
        {
            Console.WriteLine($"Hola, me llamo {Nombre}, tengo {Edad} años Y mi Id de alumno es {Id}.");
        }
    }

}