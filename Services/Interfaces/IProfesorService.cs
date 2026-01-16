using POO.Models;
namespace POO.Services.Interfaces
{
    public interface IProfesorService
    {
        void RegisterProfesor(Profesor profesor);
        Profesor ObtenerPorCodigo(string codigo);
        IEnumerable<Profesor> ObtenerTodos();
        void DesactivarProfesor(string codigo);
    }
}