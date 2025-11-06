using POO.Models;

class Program
{
    static void Main()
    {
        var personas = new List<Persona>();

        AgregarPersonas(personas);
        MostrarPresentaciones(personas);
        EjecutarAcciones(personas);
    }

    static void AgregarPersonas(List<Persona> personas)
    {
        try
        {
            personas.Add(new Alumno("Ana", "Gómez", 17, "11°", 92));
            personas.Add(new Alumno("Carlos", "Gómez", 17, "9°", 30));
            personas.Add(new Profesor("Carlos", "Ramírez", 38, "Matemáticas", 1500m));
            personas.Add(new Director("María", "López", 50, "Ciencias", 2000m));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de validación al agregar personas: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }

    static void MostrarPresentaciones(List<Persona> personas)
    {
        Console.WriteLine("=== Presentaciones ===");
        foreach (var persona in personas)
        {
            try
            {
                persona.Presentarse(); // POLIMORFISMO
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al presentar: {ex.Message}");
            }
        }
    }

    static void EjecutarAcciones(List<Persona> personas)
    {
        Console.WriteLine("\n=== Acciones individuales ===");

        foreach (var persona in personas)
        {
            try
            {
                if (persona is IEstudiante estudiante)
                {
                    estudiante.Estudiar();
                    estudiante.RendirExamen();
                }
                else if (persona is Director director)
                {
                    director.Supervisar();
                    Console.WriteLine($"Salario (Director): {director.CalcularSalario():C}");
                }
                else if (persona is IEmpleado empleado)
                {
                    empleado.Trabajar();
                    Console.WriteLine($"Salario: {empleado.CalcularSalario():C}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en acción individual: {ex.Message}");
            }
        }
    }
}
