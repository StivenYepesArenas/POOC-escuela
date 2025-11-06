using System.ComponentModel;

namespace POO.Models;

class Director : Personas, IEmpleado
{
    private string _departamento = string.Empty;
    private decimal _salario;
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
    public decimal Salario
    {
        get { return _salario; }
        set
        {
            if (value < 0)
            {
                throw new Exception("El salario no puede ser negativo");
            }
            _salario = value;
        }
    }

    public Director(string nombre, string apellido, int edad, string departamento, decimal salario) : base(nombre, apellido, edad)
    {
        Departamento = departamento;
        Salario = salario;
    }

    public override void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre}, director del departamento de {Departamento}.");
    }

    public void Supervisasr()
    {
        Console.WriteLine($"{Nombre} está supervisando las actividades.");
    }
    public decimal CalcularSalario()
    {
        return Salario;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Director: {Nombre} {Apellido}, Edad: {Edad}, Departamento: {Departamento}, Salario: {Salario:C}");
    }

}
