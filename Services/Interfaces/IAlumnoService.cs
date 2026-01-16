using POO.Models;
namespace POO.Services.Interfaces
{
    public interface IAlumnoService
    {
        void RegisterAlumno(Alumno alumno);
        Alumno ObtenerPorCodigo(string codigo);
        IEnumerable<Alumno> ObtenerTodos();
        void DesactivarAlumno(string codigo);

    }
}