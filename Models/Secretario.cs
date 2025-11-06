namespace POO.Models
{
    public class Secretario : Persona, IEmpleado
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
                    throw new ArgumentException("El departamento no puede ir vacio");
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
                    throw new ArgumentOutOfRangeException("El salario no puede ser negativo");
                }
                _salario = value;
            }
        }
        public Secretario() : base() { }
        public Secretario(string nombre, string apellido, int edad, string departamento, decimal salario) : base(nombre, apellido, edad)
        {
            Departamento = departamento;
            Salario = salario;
        }
        public override void Presentarse()
        {
            Console.WriteLine($"Hola soy el secretario {Nombre}, trabajo en el departamento de {Departamento}.");
        }

        public void Trabajar()
        {
            Console.WriteLine($"{Nombre} está organizando documentos en el departamento de {Departamento}.");
        }
        
        public decimal CalcularSalario()
        {
            decimal bonus = Salario * 0.03m;
            Salario += bonus;
            return Salario;
        }

    }
}