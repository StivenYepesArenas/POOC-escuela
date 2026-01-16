// namespace POO.Models;
// public class Profesor : Persona
// {
//     private string _materia = string.Empty;
//     private decimal _salario;

//     public string Materia
//     {
//         get { return _materia; }
//         set
//         {
//             if (string.IsNullOrWhiteSpace(value))
//             {
//                 throw new ArgumentException("La materia no puede estar vacía.");
//             }
//             _materia = value;
//         }
//     }
//     public decimal Salario
//     {
//         get { return _salario; }
//         set
//         {
//             if (value < 0)
//             {
//                 throw new ArgumentException("El salario no puede ser negativo.");
//             }
//             _salario = value;
//         }
//     }

//     public Profesor() { }

//     public Profesor(string nombre, string apellido, int edad, string materia, decimal salario) : base(nombre, apellido, edad)
//     {
//         Materia = materia;
//         Salario = salario;
//     }

//     public override void Presentarse()
//     {
//         Console.WriteLine($"Hola, soy el profesor {Nombre}, enseño {Materia}.");

//     }
//     public decimal CalcularSalario()
//     {
//         decimal bonus = Salario * 0.05m;
//         Salario += bonus;
//         return Salario;
//     }
//     public void Trabajar()
//     {
//         Console.WriteLine($"{Nombre} está dando clase de {Materia}.");
//     }
// }