namespace POO.Models;

//Establecer clase Alumno que herede de Personas.

class Alumno : Personas
{
    private string _grado = string.Empty;
    private int _promedio;

    public string Grado
    {
        get { return _grado; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("El grado no puede ser vacio");
            }
            _grado = value;
        }
    }

    public int Promedio
    {
        get { return _promedio; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new Exception("El promedio debe estar entre 0 y 100");
            }
            _promedio = value;
        }
    }

    public Alumno() { }
    public Alumno(string nombre, string apellido, int edad, string grado, int promedio) : base(nombre, apellido, edad)
    {
        Grado = grado;
        Promedio = promedio;
    }

    public void Estudiar()
    {
        Console.WriteLine($"{Nombre} está estudiando para mejorar su promedio.");

    }

    public override void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre}, alumno del grado {Grado}, y mi promedio es {Promedio}.");

    }

}