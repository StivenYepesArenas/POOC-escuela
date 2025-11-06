namespace POO.Models;
public class Director : Persona, IEmpleado
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

    public void Supervisar()
    {
        Console.WriteLine($"{Nombre} está supervisando las actividades.");
    }
    public decimal CalcularSalario()
    {
        decimal bonus = Salario * 0.10m;
        Salario += bonus;
        return Salario;
    }
    public void Trabajar()
    {
        Console.WriteLine($"{Nombre} está trabajando en la gestión del departamento de {Departamento}.");
    }

}
