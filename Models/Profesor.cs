namespace POO.Models;

class Profesor : Personas
{
    private string _materia = string.Empty;

    public string Materia
    {
        get { return _materia; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("La materia no puede estar vacía.");
            }
            _materia = value;
        }

    }

    public Profesor() { }

    public Profesor(string nombre, string apellido, int edad, string materia) : base(nombre, apellido, edad)
    {
        Materia = materia;
    }

    public void Enseñar()
    {
        Console.WriteLine($"{Nombre} está enseñando la materia de {Materia}.");
    }

    public override void Presentarse()
    {
        Console.WriteLine($"Hola, soy el profesor {Nombre}, enseño {Materia}.");

    }
}