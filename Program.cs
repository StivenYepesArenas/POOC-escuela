using POO.Models;
using System;

class Program
{
    static void Main(String[] args)
    {
       

        List<Personas> personas = new List<Personas>
        {
            new Personas("Juan", "Perez", 25),
            new Alumno("Ana", "Martinez", 19, "11vo", 90),
            new Profesor("Luis", "Ramirez", 45, "Historia"),
            new Alumno("Pedro", "Sanchez", 18, "10mo", 75),
            new Profesor("Marta", "Diaz", 38, "Ciencias")
        };

        foreach (var persona in personas)
        {
            persona.Presentarse();
        }  
    }
}