namespace POO.Models;

class Profesor : Personas, IEmpleado
{
    private string _materia = string.Empty;
    private decimal _salario;

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
    public decimal Salario
    {
        get { return _salario; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("El salario no puede ser negativo.");
            }
            _salario = value;
        }
    }

    public Profesor() { }

    public Profesor(string nombre, string apellido, int edad, string materia, decimal salario) : base(nombre, apellido, edad)
    {
        Materia = materia;
        Salario = salario;
    }

    public void Enseñar()
    {
        Console.WriteLine($"{Nombre} está enseñando la materia de {Materia}.");
    }

    public override void Presentarse()
    {
        Console.WriteLine($"Hola, soy el profesor {Nombre}, enseño {Materia}.");

    }
    public decimal CalcularSalario()
    {
        return Salario;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Profesor: {Nombre} {Apellido}, Edad: {Edad}, Materia: {Materia}, Salario: {Salario:C}");
    }
}