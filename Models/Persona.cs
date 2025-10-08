namespace POO.Models;

public class Persona
{
    private int _edad;
    private string _Nombre = string.Empty;
    public int Edad
    {
        get { return _edad; }
        set
        {
            if (value < 0)
            {
                throw new Exception("La edad no puede ser negativa");
            }
            _edad = value;
        }
    }

    public string Nombre
    {
        get { return _Nombre; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("El nombre no puede ser vacio");
            }
            _Nombre = value;
        }
    }

    public Persona() { }

    public Persona(int edad, string nombre)
    {
        Edad = edad;
        Nombre = nombre;
    }

    public virtual void Saludar()
    {
        Console.WriteLine($"Hola, me llamo {Nombre} y tengo {Edad} años.");
    }
}