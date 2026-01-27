using POO.Models;
using POO.Repositories;
using POO.Services;


Console.WriteLine("=== PRUEBA ALUMNO SERVICE ===");

var alumnoRepository = new AlumnoRepositoryInMemory();
var alumnoService = new AlumnoService(alumnoRepository);

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

    alumnoService.Register(alumno1);
    alumnoService.Register(alumno2);
    Console.WriteLine("Alumnos registrados correctamente.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al registrar alumnos: {ex.Message}");
}

Console.WriteLine("\n=== LISTA DE ALUMNOS ===");

foreach (var alumno in alumnoService.GetAll())
{
    Console.WriteLine($"Código: {alumno.Codigo}, Nombre: {alumno.Nombre} {alumno.Apellido},Activo: {alumno.Activo}");
}

Console.WriteLine("\n=== DESACTIVAR ALUMNO A001 ===");
try
{
    alumnoService.Desactivate("A001");
    Console.WriteLine("Alumno desactivado correctamente.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("\n=== ESTADO FINAL ===");
foreach (var alumno in alumnoService.GetAll())
{
    Console.WriteLine(
        $"Código: {alumno.Codigo} | Nombre: {alumno.Nombre} | Activo: {alumno.Activo}"
    );
}

                                     //-------------------------------------------------------------//

Console.WriteLine("=== PRUEBA PROFESOR SERVICE ===");

var profesorService = new ProfesorService();

try
{
    var profesor1 = new Profesor(
        codigo: "P001",
        nombre: "Luis",
        apellido: "Martinez",
        edad: 35,
        materia: "Matemáticas"
    );
    var profesor2 = new Profesor(
        codigo: "P002",
        nombre: "Ana",
        apellido: "Lopez",
        edad: 29,
        materia: "Historia"
    );
    profesorService.RegisterProfesor(profesor1);
    profesorService.RegisterProfesor(profesor2);
    Console.WriteLine("Profesores registrados correctamente.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al registrar profesores: {ex.Message}");
}


Console.WriteLine("\n=== LISTA DE PROFESORES ===");

foreach (var profesor in profesorService.ObtenerTodos())
{
    Console.WriteLine($"Código: {profesor.Codigo}, Nombre: {profesor.Nombre} {profesor.Apellido}, Activo: {profesor.Activo}");
}

Console.WriteLine("\n=== DESACTIVAR PROFESOR P001 ===");

try
{
    profesorService.DesactivarProfesor("P001");
    Console.WriteLine("Profesor desactivado correctamente.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("\n=== ESTADO FINAL ===");

foreach (var profesor in profesorService.ObtenerTodos())
{
    Console.WriteLine(
        $"Código: {profesor.Codigo} | Nombre: {profesor.Nombre} | Activo: {profesor.Activo}"
    );
}