using POO.Models;
using POO.Services;

Console.WriteLine("=== PRUEBA ALUMNO SERVICE ===");

var alumnoService = new AlumnoService();
try
{
    var alumno1 = new Alumno(
            codigo: "A002",
            nombre: "Maria",
            apellido: "Gomez",
            edad: 18,
            grado: "11°",
            promedio: 90
        );
    var alumno2 = new Alumno(
            codigo: "A001",
            nombre: "Juan",
            apellido: "Perez",
            edad: 20,
            grado: "10°",
            promedio: 85
            );

    alumnoService.RegisterAlumno(alumno1);
    alumnoService.RegisterAlumno(alumno2);
    Console.WriteLine("Alumnos registrados correctamente.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al registrar alumnos: {ex.Message}");
}

Console.WriteLine("\n=== LISTA DE ALUMNOS ===");

foreach (var alumno in alumnoService.ObtenerTodos())
{
    Console.WriteLine($"Código: {alumno.Codigo}, Nombre: {alumno.Nombre} {alumno.Apellido},Activo: {alumno.Activo}");
}

Console.WriteLine("\n=== DESACTIVAR ALUMNO A001 ===");
try
{
    alumnoService.DesactivarAlumno("A001");
    Console.WriteLine("Alumno desactivado correctamente.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("\n=== ESTADO FINAL ===");
foreach (var alumno in alumnoService.ObtenerTodos())
{
    Console.WriteLine(
        $"Código: {alumno.Codigo} | Nombre: {alumno.Nombre} | Activo: {alumno.Activo}"
    );
}