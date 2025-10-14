using POO.Models;

class Program
{
    static void Main()
    {
        // Creamos una lista del tipo de la clase base
        List<Personas> personas = new List<Personas>();

        try
        {
            // Agregamos objetos de diferentes clases derivadas
            personas.Add(new Alumno("Ana", "Gómez", 17, "11°", 92));
            personas.Add(new Alumno("Carlos", "Gómez", 17, "9°", 30));
            personas.Add(new Profesor("Carlos", "Ramírez", 38, "Matemáticas"));
            personas.Add(new Director("María", "López", 50, "Ciencias"));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de validación al agregar personas: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }

        Console.WriteLine("=== Presentaciones ===");
        foreach (var persona in personas)
        {
            try
            {
                persona.Presentarse(); // Aquí ocurre el POLIMORFISMO
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al presentar: {ex.Message}");
            }
        }

        Console.WriteLine("\n=== Acciones individuales ===");

        // Ahora ejecutamos métodos específicos usando casting
        foreach (var persona in personas)
        {
            try
            {
                if (persona is Alumno alumno)
                {
                    alumno.Estudiar();
                }
                else if (persona is Profesor profesor)
                {
                    profesor.Enseñar();
                }
                else if (persona is Director director)
                {
                    director.Supervisasr();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en acción individual: {ex.Message}");
            }
        }
    }
}