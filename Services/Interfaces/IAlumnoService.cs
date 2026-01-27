using POO.Models;
namespace POO.Services.Interfaces
{
    public interface IAlumnoService
    {
        void Register(Alumno alumno);
        Alumno GetByCode(string codigo);
        IEnumerable<Alumno> GetAll();
        void Desactivate(string codigo);

    }
}