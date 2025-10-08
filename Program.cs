using POO.Models;

class Program
{
    static void Main(String[] args)
    {
        /*Alumno alumno = new Alumno();
        Alumno alu1 = new Alumno(32, "Estiven", "Yepes");
        Console.WriteLine(alu1.Nombre);
        Console.WriteLine(alu1.Apellido);
        Console.WriteLine(alu1.Id);*/

        Persona persona1 = new Persona(27, "Estiven Yepes");
        persona1.Saludar();

    }
}