namespace POO.Models;

public abstract class  Persona  
{
    //Campos privados para los atributos.
    private string _nombre = string.Empty;
    private string _apellido = string.Empty;
    private int _edad;

    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El nombre no puede ser vacio");
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
                throw new ArgumentException("El apellido no puede ser vacio", nameof(value));
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
                throw new ArgumentOutOfRangeException("La edad no puede ser negativa");
            }
            _edad = value;
        }
    }

    protected Persona  () { }

    protected Persona  (string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }

    public abstract void Presentarse();
    
}