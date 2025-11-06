namespace POO.Models;

public class Tutor :  Alumno, IEstudiante
{
    private int _cantidadDeClases = 0;

    public int CantidadDeClases
    {
        get { return _cantidadDeClases; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("La cantidad de clases no puede ser negativa");
            }
            _cantidadDeClases = value;
        }
    }

    public Tutor() { }
    public Tutor(string nombre, string apellido, int edad, string grado, int promedio, int cantidadDeClases)
        : base(nombre, apellido, edad, grado, promedio)
    {
        CantidadDeClases = cantidadDeClases;
    }

    public override void Estudiar()
    {
        Console.WriteLine($"{Nombre} está estudiando y preparando material para sus tutorías.");
    }
    public override void RendirExamen()
    {
        Console.WriteLine($"{Nombre} está rindiendo un examen.");
    }
    public void DarClaseParticular()
    {
        Console.WriteLine($"{Nombre} está dando una clase a {CantidadDeClases} estudiantes.");
    }

}