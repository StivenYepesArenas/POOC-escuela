using POO.Models;
namespace POO.Repositories.Interfaces
{
    public interface IAlumnoRepository
    {
        void Add(Alumno alumno);
        Alumno? GetByCode(string codigo);
        IEnumerable<Alumno> GetAll();
    }
}