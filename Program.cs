using POO.Models;

class Program
{
    static void Main()
    {
        // Creamos una lista del tipo de la clase base
        List<Personas> personas = new List<Personas>();

        // Agregamos objetos de diferentes clases
        personas.Add(new Personas("Juan", "Pérez", 45));
        personas.Add(new Alumno("Ana", "Gómez", 17, "11°", 92));
        personas.Add(new Profesor("Carlos", "Ramírez", 38, "Matemáticas"));

        // Recorremos la lista y llamamos Presentarse()
        Console.WriteLine("=== Presentaciones ===");
        foreach (var persona in personas)
        {
            persona.Presentarse(); // Aquí ocurre el POLIMORFISMO
        }

        Console.WriteLine("\n=== Acciones individuales ===");

        // Ahora ejecutamos métodos específicos usando casting
        foreach (var persona in personas)
        {
            if (persona is Alumno alumno)
            {
                alumno.Estudiar();
            }
            else if (persona is Profesor profesor)
            {
                profesor.Enseñar();
            }
        }
    }
}
