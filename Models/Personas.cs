using System.Diagnostics.Contracts;

namespace POO.Models;

//Establecer clase Personas con atributos Nombre, Apellido y Edad. Validar que el nombre y apellido no sean vacios y que la edad no sea negativa.
public abstract class Personas
{
    //Campos privados para los atributos.
    private string _nombre = string.Empty;
    private string _apellido = string.Empty;
    private int _edad;

    //Propiedades publicas para los atributos.
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

    //Constructor por defecto. y constructor con parametros.
    protected Personas() { }

    protected Personas(string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }

    //metodo para presentarse.

    public abstract void Presentarse();
    public void Saludar()
    {
        Console.WriteLine($"Hola, buenos dias.");
    }
    

}