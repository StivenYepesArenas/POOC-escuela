using System.ComponentModel;

namespace POO.Models;

class Director : Personas
{
    private string _departamento = string.Empty;
    public string Departamento
    {
        get { return _departamento; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("El departamento de puede ir vacio");
            }
            _departamento = value;
        }
    }

    public Director(string nombre, string apellido, int edad, string departamento) : base(nombre, apellido, edad)
    {
        Departamento = departamento;
    }

    public override void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre}, director del departamento de {Departamento}.");
    }   

    public void Supervisasr()
    {
        Console.WriteLine($"{Nombre} está supervisando las actividades.");
    }

}
